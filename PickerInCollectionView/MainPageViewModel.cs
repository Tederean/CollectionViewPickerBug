using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace PickerInCollectionView
{

  public partial class MainPageViewModel : ObservableObject
  {

    [ObservableProperty]
    private ObservableCollection<ItemViewModel> m_Items;


    public MainPageViewModel()
    {
      m_Items = new ObservableCollection<ItemViewModel>() { new(), new() };
    }


    [RelayCommand]
    private void RemoveEntry(ItemViewModel viewModel)
    {
      Items.Remove(viewModel);
    }
  }
}
