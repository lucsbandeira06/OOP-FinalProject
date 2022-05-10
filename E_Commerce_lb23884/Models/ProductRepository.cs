/*Lucas Bandeira*/
/*Student ID: 23884*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Commerce_lb23884.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public IEnumerable<Product> GetAllProduct => new List<Product>
            {
            new Product {ProductId=1, Name="Television 60 inches", Price = 395.99M,
                Description="Smart-TV 60 inches", Category = _categoryRepository.GetAllCategories.ToList()[0],
            ImageUrl="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.whathifi.com%2Fnews%2Fargos-black-friday-2019-lg-60-inch-4k-tv-now-pound429&psig=AOvVaw0Ebi53MM2PutIZoPFHuVZ5&ust=1652305004296000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCKCV-_jx1fcCFQAAAAAdAAAAABAF",
            IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://www.google.com/imgres?imgurl=https%3A%2F%2Fwww.lg.com%2Feastafrica%2Fimages%2Ftvs%2Fmd06185996%2Fgallery%2FD-01-V1.jpg&imgrefurl=https%3A%2F%2Fwww.lg.com%2Feastafrica%2Ftvs%2Flg-60UM7100PVB&tbnid=20pVtKBTWLd3GM&vet=12ahUKEwibsoD48dX3AhUFnVwKHdKvCZ4QMygKegUIARDwAg..i&docid=IJSiXQqAhjYPfM&w=1100&h=730&q=tv%2060%20inches&client=safari&ved=2ahUKEwibsoD48dX3AhUFnVwKHdKvCZ4QMygKegUIARDwAg"},

             new Product {ProductId=2, Name="Playstation 4", Price = 199.99M,
                Description="Sony Playstation 4 - white", Category = _categoryRepository.GetAllCategories.ToList()[1],
            ImageUrl="https://www.google.com/imgres?imgurl=https%3A%2F%2Fc1.staticflickr.com%2F5%2F4195%2F35094604546_fccd221e57_h.jpg&imgrefurl=https%3A%2F%2Fblog.playstation.com%2Farchive%2F2017%2F06%2F06%2Flimited-edition-gold-and-silver-consoles-join-the-playstation-4-family-this-month&tbnid=AhByg0rOq5iQxM&vet=12ahUKEwiIqfj689X3AhXyolwKHcFiA0kQMygdegUIARDLAg..i&docid=jhp4dEtca_DXwM&w=1600&h=1066&q=playstation%204&client=safari&ved=2ahUKEwiIqfj689X3AhXyolwKHcFiA0kQMygdegUIARDLAg",
            IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://www.google.com/imgres?imgurl=https%3A%2F%2Fc1.staticflickr.com%2F5%2F4195%2F35094604546_fccd221e57_h.jpg&imgrefurl=https%3A%2F%2Fblog.playstation.com%2Farchive%2F2017%2F06%2F06%2Flimited-edition-gold-and-silver-consoles-join-the-playstation-4-family-this-month&tbnid=AhByg0rOq5iQxM&vet=12ahUKEwiIqfj689X3AhXyolwKHcFiA0kQMygdegUIARDLAg..i&docid=jhp4dEtca_DXwM&w=1600&h=1066&q=playstation%204&client=safari&ved=2ahUKEwiIqfj689X3AhXyolwKHcFiA0kQMygdegUIARDLAg"},
            
        new Product {ProductId=3, Name="Fridge", Price = 699.99M,
                Description="Inox Fridge", Category = _categoryRepository.GetAllCategories.ToList()[2],
            ImageUrl="https://www.google.com/imgres?imgurl=https%3A%2F%2Fbrain-images-ssl.cdn.dixons.com%2F3%2F7%2F10205773%2Fu_10205773.jpg&imgrefurl=https%3A%2F%2Fwww.currys.ie%2Fieen%2Fhousehold-appliances%2Frefrigeration%2Ffridge-freezers%2Fkenwood-ksbs4dx20-fridge-freezer-inox-10205773-pdt.html&tbnid=zZp-BJec13vyeM&vet=12ahUKEwjE4J7F9NX3AhVxSkEAHTsrDM0QMygCegUIARCHAw..i&docid=v8qHZn8OZwMhoM&w=1000&h=887&q=Inox%20fridge&client=safari&ved=2ahUKEwjE4J7F9NX3AhVxSkEAHTsrDM0QMygCegUIARCHAw",
            IsInStock=true,IsOnSale=false,ImageThumbnailUrl="https://www.google.com/imgres?imgurl=https%3A%2F%2Fbrain-images-ssl.cdn.dixons.com%2F3%2F7%2F10205773%2Fu_10205773.jpg&imgrefurl=https%3A%2F%2Fwww.currys.ie%2Fieen%2Fhousehold-appliances%2Frefrigeration%2Ffridge-freezers%2Fkenwood-ksbs4dx20-fridge-freezer-inox-10205773-pdt.html&tbnid=zZp-BJec13vyeM&vet=12ahUKEwjE4J7F9NX3AhVxSkEAHTsrDM0QMygCegUIARCHAw..i&docid=v8qHZn8OZwMhoM&w=1000&h=887&q=Inox%20fridge&client=safari&ved=2ahUKEwjE4J7F9NX3AhVxSkEAHTsrDM0QMygCegUIARCHAw"}
};





        public IEnumerable<Product> GetProductOnSale => throw new NotImplementedException();

      

        public Product GetProductById(int productId)
        {
            return GetAllProduct.FirstOrDefault(c => c.ProductId == productId);
        }
    }
}
