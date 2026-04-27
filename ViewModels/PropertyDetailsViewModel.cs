using System;
using System.Windows.Input;

namespace StayFinder.ViewModels
{
    public class PropertyDetailsViewModel : BaseViewModel
    {
        public Property Property { get; set; }

        public ICommand FavoriteCommand { get; }
        public ICommand ReserveCommand { get; }

        public PropertyDetailsViewModel()
        {
            FavoriteCommand = new RelayCommand(ToggleFavorite);
            ReserveCommand = new RelayCommand(Reserve);
        }

        public void LoadProperty(int propertyId)
        {
            // Logic to load property by propertyId
        }

        private void ToggleFavorite()
        {
            // Logic to toggle favorite status
        }

        private void Reserve()
        {
            // Logic to reserve the property
        }
    }
}