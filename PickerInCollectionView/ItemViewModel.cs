using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace PickerInCollectionView
{

  public partial class ItemViewModel : ObservableObject
  {

    [ObservableProperty]
    private ObservableCollection<string> m_AvailablePickerEntries;

    [ObservableProperty]
    private string m_SelectedPickerEntry;


    public ItemViewModel()
    {
      m_AvailablePickerEntries = new ObservableCollection<string>() { "One", "Two", "Three" };
      m_SelectedPickerEntry = m_AvailablePickerEntries.First();
    }
  }
}
