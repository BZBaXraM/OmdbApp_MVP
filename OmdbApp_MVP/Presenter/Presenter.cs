using OmdbApp_MVP.Model;
using OmdbApp_MVP.View;

namespace OmdbApp_MVP
{
    internal class Presenter
    {
        private readonly Movie? _movie; // Model
        private readonly SearchResult? _searchResult; // Model
        private readonly OmdbViewForm? _view; // View

        public Presenter(OmdbViewForm? view)
        {
            _view = view;
            _movie = new Movie();
            _searchResult = new SearchResult();
            _view!.AddHandler += AddHandler;
            _view!.RemoveHandler += RemoveHandler;
        }

        private void RemoveHandler(object? sender, EventArgs e)
        {
            _view!.listBox1.Items.Remove(0);
        }

        private void AddHandler(object? sender, EventArgs e)
        {
            _view!.listBox1.DataSource = _searchResult?.Search?.Select(x => $"{x.Title}").ToList();
        }

    }
}