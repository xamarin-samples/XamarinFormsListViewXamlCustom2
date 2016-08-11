# XamarinFormsListViewXamlCustom2

Sample: Using Xamarin.Forms.ListView on XAML, with outside custom ContentView.
## Pickuped code
### Page1.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamarinFormsListViewXamlCustom2.Page1"
             xmlns:local="clr-namespace:XamarinFormsListViewXamlCustom2;assembly=XamarinFormsListViewXamlCustom2"
             >
    <ListView x:Name="mylist" ItemsSource="{Binding}" VerticalOptions="FillAndExpand">
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <local:MyListItemView />
                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</ContentPage>
```

### Page1.xaml.cs
```
public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();

        // Make data list
        List<ItemInfo> list = new List<ItemInfo>();
        list.Add(new ItemInfo { Name = "Apple", Score = 100 });
        list.Add(new ItemInfo { Name = "Banana", Score = 150 });
        list.Add(new ItemInfo { Name = "Candy", Score = 80 });
        list.Add(new ItemInfo { Name = "Drop", Score = -10 });

        // Bind
        this.BindingContext = list;
    }
}
```

### MyListItemView.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentView xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamarinFormsListViewXamlCustom2.MyListItemView">
    <ContentView.Content>
        <StackLayout Orientation="Horizontal" Padding="5">
            <Label Text="{Binding Name}" WidthRequest="100" />
            <Label Text="{Binding Score}" />
        </StackLayout>
    </ContentView.Content>
</ContentView>
```


## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsListViewXamlCustom2/master/screenshots/screenshot.png)
