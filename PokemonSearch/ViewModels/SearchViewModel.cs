using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using PokeCommon.Utils;
using PokemonDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSearch.ViewModels
{
    public partial class SearchViewModel : ViewModelBase
    {
        public string[] SortRule { get; set; } = 
            [
            "依照图鉴编号排序",
            "依照种族值降序",
            "依照种族值升序",
            "依照HP降序",
            "依照HP升序",
            "依照攻击降序",
            "依照攻击升序",
            "依照防御降序",
            "依照防御升序",
            "依照特攻降序",
            "依照特攻值升序",
            "依照特防值降序",
            "依照特防升序",
            "依照速度值降序",
            "依照速度值升序",
            ];

        [ObservableProperty]
        //string _iconImg = "/Assets/img_pokei128/icon0000_f00_s0.png";
        Bitmap _iconImg = ImageHelper.LoadFromResource(new Uri("avares://PokemonSearch/Assets/img_pokei128/icon0730_f00_s0.png"));
        public PokeType[] TypeList { get; set; } = PokemonDBInMemory.Types.Prepend(new PokeType { Name_Chs = "(无)"}).ToArray();
        public string[] Abilities { get; set; } = PokemonDBInMemory.Abilities.Select(s => s.Name_Chs).ToArray();
        public Pokemon[] Pokemons { get; set; } = PokemonDBInMemory.Pokemons.ToArray();
    }
}
