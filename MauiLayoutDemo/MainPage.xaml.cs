namespace MauiLayoutDemo;

public partial class MainPage : ContentPage
{
    public List<Product> Products => Getproducts();

    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

	private List<Product> Getproducts()
    {
        List<Product> products = new()
        {
            new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
             new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),

        };

        return products;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        SetSelected();
    }


    public void SetSelected()
    {
        var ele = ((CollectionView)GetTemplateChild("productList"));
        IEnumerable<Product> itemSource = (IEnumerable<Product>)ele.ItemsSource;

        var toRemove = ele.SelectedItems.ToList().Where(x => ((Product)x).ID  >= 5).ToList();
        var toAdd = itemSource.Where(x => x.ID < 5).ToList();

        ele.SelectedItems.Clear();
        toAdd.ToList().ForEach(x => ele.SelectedItems.Add(x));

       
    }
}

