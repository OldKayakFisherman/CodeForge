using System.Collections.ObjectModel;

namespace SystemBuddy.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<CategoryTreeNode> Items { get; } = new ObservableCollection<CategoryTreeNode>();

    public MainWindowViewModel()
    {
        FillCategoryNodes();
    }

    private void FillCategoryNodes()
    {
        var computerNode = new CategoryTreeNode("Host-Name");

        var logNode = new CategoryTreeNode("Logs");
        logNode.Children.Add(new CategoryTreeNode("Kernel"));
        logNode.Children.Add(new CategoryTreeNode("Systemd"));
        logNode.Children.Add(new CategoryTreeNode("Wireless"));
        
        computerNode.Children.Add(logNode);
        
        Items.Add(computerNode);
    }
    
}

public class CategoryTreeNode
{
    public ObservableCollection<CategoryTreeNode> Children { get; set; } = new ObservableCollection<CategoryTreeNode>();
    public string Category { get; set; }

    public CategoryTreeNode(string categoryName)
    {
        this.Category = categoryName;
    }
    
}