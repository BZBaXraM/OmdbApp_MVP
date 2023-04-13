using OmdbApp_MVP.Model;
using System.Text.Json;

namespace OmdbApp_MVP.View
{
    public partial class OmdbViewForm : Form
    {
        private readonly List<Movie>? movies = new();
        private readonly HttpClient? client = new();
        private readonly List<string>? movieList = new();

        public OmdbViewForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://www.omdbapi.com/");
            movieList.Clear();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            foreach (string item in listBox1.Items)
            {
                movieList.Add(item);
            }
        }

        public EventHandler AddHandler { get; set; }
        public EventHandler RemoveHandler { get; set; }

        private async void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedTitle = listBox1.SelectedItem as string;
                var selectedMovie = movies?.FirstOrDefault(x => x.Title == selectedTitle);
                if (selectedMovie != null)
                {
                    pictureBox1.Image = await LoadImageFromUrl(selectedMovie.Poster!);
                }
            }
        }


        private static async Task<Image> LoadImageFromUrl(string poster)
        {
            using HttpClient client = new();
            var response = await client.GetByteArrayAsync(poster);
            using var stream = new MemoryStream(response);
            return Image.FromStream(stream);
        }


        private async void Add_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //movies.Clear();
            HttpResponseMessage httpResponse =
                await client!.GetAsync($"?i=tt3896198&apikey=dfb9193a&s={textBox1.Text.ToUpper()}");
            if (httpResponse.IsSuccessStatusCode)
            {
                var json = await httpResponse.Content.ReadAsStringAsync();
                var root = JsonSerializer.Deserialize<SearchResult>(json);
                try
                {
                    if (root?.Search != null)
                    {
                        foreach (var item in root.Search)
                        {
                            AddHandler.Invoke(sender, e);
                            listBox1.Items.Add(item.Title!);
                            movies!.Add(item);
                            using var imageResponse = await client.GetAsync(item.Poster);
                            if (imageResponse.IsSuccessStatusCode)
                            {
                                using var stream = await imageResponse.Content.ReadAsStreamAsync();
                                Image image = Image.FromStream(stream);
                                pictureBox1.Image = image;
                            }

                            await Task.Delay(200);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem!);
            RemoveHandler.Invoke(sender, e);
            await Task.Delay(200);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == false)
            {
                int index = listBox1.FindString(textBox2.Text);
                if (index != ListBox.NoMatches)
                {
                    listBox1.SelectedIndex = index;
                }
            }
            else
            {
                listBox1.ClearSelected();
            }
        }
    }
}