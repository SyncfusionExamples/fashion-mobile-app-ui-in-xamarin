using System;
using System.Collections.ObjectModel;
using FashionMobileApp.Models;
namespace FashionMobileApp.ViewModels
{
    public class FashionViewModel
    {
        public ObservableCollection<Sizes> sizes { get; set; }
        public ObservableCollection<CartDetails> CartDetails { get; set; }


        public FashionViewModel()
        {
            sizes = new ObservableCollection<Sizes>()
            {
                new Sizes { SizeDescripcion = "S"  },
                new Sizes { SizeDescripcion = "M"  },
                new Sizes { SizeDescripcion = "L"  },
                new Sizes { SizeDescripcion = "XL" }
            };

            CartDetails = new ObservableCollection<CartDetails>
            {
                new CartDetails { Picture="Model02", Name="Purple Outfit set", Price="$110", Size="M"},
                new CartDetails { Picture="Model03", Name="Maroon Outfit set", Price="$110", Size="XL"},
                new CartDetails { Picture="Model04", Name="Dale T-Shirt", Price="$60", Size="L"}
            };
        }
    }
}
