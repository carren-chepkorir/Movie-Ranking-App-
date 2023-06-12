using Microsoft.AspNetCore.Mvc;
using Ranking_App.Models;



namespace Ranking_App.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ItemController : ControllerBase

    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id =1, Title ="The GodFather",ImageId=1,Ranking =0,ItemType=1},

            new ItemModel{Id =2, Title ="HighLander",ImageId=2,Ranking =0,ItemType=1},

            new ItemModel{Id =3, Title ="Highlander II",ImageId=3,Ranking =0,ItemType=1},

            new ItemModel{Id =4, Title ="The Last of Mohicans",ImageId=4,Ranking =0,ItemType=1},

            new ItemModel{Id =5, Title ="PoliceAcademy",ImageId=5,Ranking =0,ItemType=1},

            new ItemModel{Id =6, Title ="The RearWindow ",ImageId=6,Ranking =0,ItemType=1},

            new ItemModel{Id =7, Title ="The RoadHouse",ImageId=7,Ranking =0,ItemType=1},

            new ItemModel{Id =8, Title ="The Shawshank",ImageId=8,Ranking =0,ItemType=1},

            new ItemModel{Id =9, Title ="StarTreck",ImageId=9,Ranking =0,ItemType=1},

            new ItemModel{Id =10, Title ="Superman4",ImageId=10,Ranking =0,ItemType=1},


        };
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int ItemType)
        {
            ItemModel []items=Items.Where(i=>i.ItemType==ItemType).ToArray();
            return items;
        }
        //this is a method to get an array of itemtype that the user requested.




  }       
    
}
