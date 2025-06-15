using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelperControls.Models;

public class PaginationModel : ChangeNotifierModel
{
    private int _totalItems;

    public int total_itmes
    {
        get => _totalItems;
        set
        {
            _totalItems = value;
            OnPropertyChanged();
        }
    }

    private int _itmems_per_page;

    public int itm_per_page
    {
        get => _itmems_per_page;
        set
        {
            _itmems_per_page = value;
            OnPropertyChanged();
        }
    }

    private int _current_page;

    public int currentPage
    {
        get => _current_page;
        set
        {
            _current_page = value;
            OnPropertyChanged();
        }
    }

    private int _total_pages;

    public int totalPages
    {
        get => _total_pages;
        set
        {
            _total_pages = value;
            OnPropertyChanged();
        }
    }

    public PaginationModel()
    {
        currentPage = 1;
        totalPages = 1;
    }
}

public class ChangeNotifierModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([ CallerMemberName ]string? propertyName = null)
    {
        // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /* protected bool SetField<T>(ref T field, T value, [ CallerMemberName ]string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    } */
}
