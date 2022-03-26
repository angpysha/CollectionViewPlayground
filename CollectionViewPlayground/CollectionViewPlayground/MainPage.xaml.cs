using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewPlayground
{
    public class Item
    {
        public double Height { get; set; }
        public Color BackgroundColor { get; set; }
        public string Text { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CollectionView.ItemsSource = new List<Item>()
            {
                new Item()
                {
                    Height = 120,
                    BackgroundColor = Color.Aqua,
                    Text = "Lorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 80,
                    BackgroundColor = Color.Bisque,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 40,
                    BackgroundColor = Color.Blue,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 150,
                    BackgroundColor = Color.Chartreuse,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 65,
                    BackgroundColor = Color.Chocolate,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 200,
                    BackgroundColor = Color.Fuchsia,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 144,
                    BackgroundColor = Color.Gold,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 80,
                    BackgroundColor = Color.Gray,
                    Text = "Lorem ipsum"
                },
                new Item()
                {
                    Height = 25,
                    BackgroundColor = Color.Green,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 180,
                    BackgroundColor = Color.Orange,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 212,
                    BackgroundColor = Color.Olive,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 55,
                    BackgroundColor = Color.DarkBlue,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 350,
                    BackgroundColor = Color.Yellow,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
                new Item()
                {
                    Height = 168,
                    BackgroundColor = Color.Maroon,
                    Text = "Lorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set ametLorem ipsum dolor set amet"
                },
            };
        }
    }
}