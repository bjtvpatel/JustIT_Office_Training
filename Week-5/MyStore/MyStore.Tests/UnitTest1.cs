using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyStore.Controllers;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Entities;
using MyStore.Models;

namespace MyStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void Can_Paginate()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup((m => m.Products)).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1"},
                new Product {ProductId = 2, ProductName = "p2"},
                new Product {ProductId = 3, ProductName = "p3"},
                new Product {ProductId = 4, ProductName = "p4"},
                new Product {ProductId = 5, ProductName = "p5"}

            });

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            //Act
            ProductListViewModel result = (ProductListViewModel) controller.List(null, 2).Model;

            //Assert
            Product[] prodArray = result.Products.ToArray();
            Assert.IsTrue(prodArray.Length == 2);
            Assert.AreEqual(prodArray[0].ProductName, "p4");
            Assert.AreEqual(prodArray[1].ProductName, "p5");

        }

        [TestMethod]
        public void Can_Send_Pagination_View_Model()
        {

            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup((m => m.Products)).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1"},
                new Product {ProductId = 2, ProductName = "p2"},
                new Product {ProductId = 3, ProductName = "p3"},
                new Product {ProductId = 4, ProductName = "p4"},
                new Product {ProductId = 5, ProductName = "p5"}

            });

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;


            //Act
            ProductListViewModel result = (ProductListViewModel) controller.List(null, 2).Model;

            //Assert
            PagingInfo pageInfo = result.PagingInfo;
            Assert.AreEqual(pageInfo.CurrentPage, 2);
            Assert.AreEqual(pageInfo.ItemsPerPage, 3);
            Assert.AreEqual(pageInfo.Totalitems, 5);
            Assert.AreEqual(pageInfo.TotalPages, 2);



        }

        [TestMethod]
        public void Can_Filter_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup((m => m.Products)).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1", SubCategory = "cat1"},
                new Product {ProductId = 2, ProductName = "p2", SubCategory = "cat2"},
                new Product {ProductId = 3, ProductName = "p3", SubCategory = "cat1"},
                new Product {ProductId = 4, ProductName = "p4", SubCategory = "cat2"},
                new Product {ProductId = 5, ProductName = "p5", SubCategory = "cat3"}

            });

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            //action
            Product[] result = ((ProductListViewModel) controller.List("cat2", 1).Model).Products.ToArray();

            //assert
            Assert.AreEqual(result.Length, 2);
            Assert.IsTrue(result[0].ProductName == "p2" && result[0].SubCategory == "cat2");
            Assert.IsTrue(result[1].ProductName == "p4" && result[1].SubCategory == "cat2");

        }

        [TestMethod]
        public void Can_Create_Category()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup((m => m.Products)).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1", SubCategory = "cat1"},
                new Product {ProductId = 2, ProductName = "p2", SubCategory = "cat2"},
                new Product {ProductId = 3, ProductName = "p3", SubCategory = "cat1"},
                new Product {ProductId = 4, ProductName = "p4", SubCategory = "cat2"},
                new Product {ProductId = 5, ProductName = "p5", SubCategory = "cat3"}

            });

            NavController controller = new NavController(mock.Object);


            //action
            String[] result = ((IEnumerable<string>) controller.Menu().Model).ToArray();

            //assert
            Assert.AreEqual(result.Length, 3);
            Assert.AreEqual(result[0], "cat1");
            Assert.AreEqual(result[1], "cat2");
            Assert.AreEqual(result[2], "cat3");

        }


        [TestMethod]
        public void Indicate_Selected_Category()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup((m => m.Products)).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1", SubCategory = "cat1"},
                new Product {ProductId = 2, ProductName = "p2", SubCategory = "cat2"},
                new Product {ProductId = 3, ProductName = "p3", SubCategory = "cat1"},
                new Product {ProductId = 4, ProductName = "p4", SubCategory = "cat2"},
                new Product {ProductId = 5, ProductName = "p5", SubCategory = "cat3"}

            });

            NavController controller = new NavController(mock.Object);

            //arrange
            string categorytoSelect = "cat2";

            //action
            string result = controller.Menu(categorytoSelect).ViewBag.SelectedCategory;

            //assert
            Assert.AreEqual(categorytoSelect, result);

        }


        [TestMethod]
        public void Generate_Category_Specific_Product_Count()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup((m => m.Products)).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1", SubCategory = "cat1"},
                new Product {ProductId = 2, ProductName = "p2", SubCategory = "cat2"},
                new Product {ProductId = 3, ProductName = "p3", SubCategory = "cat1"},
                new Product {ProductId = 4, ProductName = "p4", SubCategory = "cat2"},
                new Product {ProductId = 5, ProductName = "p5", SubCategory = "cat3"}

            });

            //Arrange 
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            //action - check the page count for different category
            int res1 = ((ProductListViewModel) controller.List("cat1").Model).PagingInfo.Totalitems;
            int res2 = ((ProductListViewModel) controller.List("cat2").Model).PagingInfo.Totalitems;
            int res3 = ((ProductListViewModel) controller.List("cat3").Model).PagingInfo.Totalitems;
            int resAll = ((ProductListViewModel) controller.List(null).Model).PagingInfo.Totalitems;

            //Assert
            Assert.AreEqual(res1, 2);
            Assert.AreEqual(res2, 2);
            Assert.AreEqual(res3, 1);
            Assert.AreEqual(resAll, 5);

        }


        
    }

    //========================================|test class for cart activity|================================
    [TestClass]
    public class CartTests
    {

        [TestMethod]
        public void Can_Add_New_Lines()
        {
            //arrange for some product

            Product p1 = new Product {ProductId = 1, ProductName = "p1"};
            Product p2 = new Product { ProductId = 2, ProductName = "p2" };

            //arrange new cart
            Cart target = new Cart();

            //act
            target.AddItem(p1, 1);
            target.AddItem(p2,1);
            CartLine[] results = target.Lines.ToArray();

            //assert
            Assert.AreEqual(results.Length,2);
            Assert.AreEqual(results[0].Product,p1);
            Assert.AreEqual(results[1].Product,p2);
        }

        //checking if it adds to existing cart or creating a new one
        [TestMethod]
        public void Can_Add_Quantity_For_Existing_Lines()
        {
            //arrange for some product

            Product p1 = new Product { ProductId = 1, ProductName = "p1" };
            Product p2 = new Product { ProductId = 2, ProductName = "p2" };

            //arrange new cart
            Cart target = new Cart();

            //act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1,10);
            CartLine[] results = target.Lines.OrderBy(c => c.Product.ProductId).ToArray();

            //assert
            Assert.AreEqual(results.Length,2);
            Assert.AreEqual(results[0].Quantity,11);
            Assert.AreEqual(results[1].Quantity,1);

        }


        //check if you can remove the item from cart 
        [TestMethod]
        public void Can_Remove_Line()
        {
            //arrange for some product

            Product p1 = new Product { ProductId = 1, ProductName = "p1" };
            Product p2 = new Product { ProductId = 2, ProductName = "p2" };
            Product p3 = new Product { ProductId = 3, ProductName = "p3" };
            //arrange new cart
            Cart target = new Cart();

            //act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p3, 10);
            target.AddItem(p2, 1);


            //act
            target.RemoveLine(p2);

            //assert
            Assert.AreEqual(target.Lines.Where(c=>c.Product == p2).Count(),0);
            Assert.AreEqual(target.Lines.Count(), 2);

        }

        //check the total cost of items in cart
        [TestMethod]
        public void Calculate_Cart_Total()
        {
            Product p1 = new Product { ProductId = 1, ProductName = "p1", Price = 100m};
            Product p2 = new Product { ProductId = 2, ProductName = "p2", Price = 150m};
            Product p3 = new Product { ProductId = 3, ProductName = "p3", Price = 50m};
            
            //arrange new cart
            Cart target = new Cart();

            //act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p3, 2);
            decimal result = target.ComputeTotalValue();
            
            //assert
            Assert.AreEqual(result,350m);
        }

        //finally i want to make sure that cart is cleare when reseting the page
        [TestMethod]
        public void Can_Clear_Contents()
        {

            Product p1 = new Product { ProductId = 1, ProductName = "p1", Price = 100m };
            Product p2 = new Product { ProductId = 2, ProductName = "p2", Price = 150m };
            Product p3 = new Product { ProductId = 3, ProductName = "p3", Price = 50m };

            //arrange new cart
            Cart target = new Cart();

            //arrange
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p3, 2);
           
            //Action
            target.Clear();

            //assert
            Assert.AreEqual(target.Lines.Count(),0);
        }


        ////checking for addtocart and then redirect to index view and when continue shopping will pass return to cataloge
        [TestMethod]
        public void Can_Add_To_Cart()
        {
            //Arrange - mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
           
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1", SubCategory = "cat1"}
                ,
            }.AsQueryable());


            //arrange - create cart
            Cart cart = new Cart();


            //arrange - create controller
            CartController target = new CartController(mock.Object);


            //act - app product to the cart
            target.AddToCart(cart, 1, null);

            //assert 

            Assert.AreEqual(cart.Lines.Count(), 1);
            Assert.AreEqual(cart.Lines.ToArray()[0].Product.ProductId,1);

        }

        //Checking if cart screen is diplaying 
        [TestMethod]
        public void Adding_Product_To_Cart_Goes_To_Cart_Screen()
        {

            //Arrange - mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId = 1, ProductName = "p1", SubCategory = "cat1"}
                ,
            }.AsQueryable());


            //arrange - create cart
            Cart cart = new Cart();


            //arrange - create controller
            CartController target = new CartController(mock.Object);


            //act - app product to the cart
            RedirectToRouteResult result = target.AddToCart(cart, 2, "myUrl");

            //Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
            Assert.AreEqual(result.RouteValues["returnUrl"], "myUrl");
        }

        //check cart content is viewed
        [TestMethod]
        public void Can_View_Cart_Content()
        {
            //arrange 
            Cart cart = new Cart();

            //arrange - create controller
            CartController target= new CartController(null);

            //act-call index method
            CartIndexViewModel result = (CartIndexViewModel) target.Index(cart, "myUrl").ViewData.Model;
            
            //assert
            Assert.AreSame(result.Cart,cart);
            Assert.AreEqual(result.ReturnUrl, "myUrl");
        }

        [TestMethod]
        public void Cannot_Checkout_Empty_Cart()
        {
            //arrange order processor
            Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();

            //arrange empty cart
            Cart cart = new Cart();

            //arrange shiping details
            ShippingDetails shippingDetails = new ShippingDetails();
           
            //arrange - instatance of controller
            CartController target = new CartController(null, mock.Object);

            //act 
            ViewResult result = target.Checkout(cart, shippingDetails);

            //assert - check order has not been passed to processor
            mock.Verify(m=>m.ProcessOrder(It.IsAny<Cart>(), It.IsAny<ShippingDetails>()), Times.Never());

            //assert - check the method is returning default view
            Assert.AreEqual("", result.ViewName);

            //assert - check that i am passiong a invalid model to view 
            Assert.AreEqual(false, result.ViewData.ModelState.IsValid);
        }


        [TestMethod]
        public void Cannot_Checkout_Invalid_ShippingDetails()
        {
            //arrange order processor
            Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();

            //arrange empty cart
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);

            //arrange - instatance of controller
            CartController target = new CartController(null, mock.Object);

            //arrange - add error to model 
            target.ModelState.AddModelError("error", "error");

            //act- try to check out
            ViewResult result = target.Checkout(cart, new ShippingDetails());

            //assert - check order has not been passed to processor
            mock.Verify(m => m.ProcessOrder(It.IsAny<Cart>(), It.IsAny<ShippingDetails>()), Times.Never());

            //assert - check the method is returning default view
            Assert.AreEqual("", result.ViewName);

            //assert - check that i am passiong a invalid model to view 
            Assert.AreEqual(false, result.ViewData.ModelState.IsValid);
        }

        [TestMethod]
        public void Can_Checkout_And_Submit_Order()
        {
            //arrange order processor
            Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();

            //arrange empty cart
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);

            //arrange - instatance of controller
            CartController target = new CartController(null, mock.Object);

            //act- try to check out
            ViewResult result = target.Checkout(cart, new ShippingDetails());

            //assert - check order has been passed to processor
            mock.Verify(m => m.ProcessOrder(It.IsAny<Cart>(), It.IsAny<ShippingDetails>()), Times.Once());

            //assert - check the method is returning Completed view
            Assert.AreEqual("Completed", result.ViewName);

            //assert - check that i am passiong a valid model to view 
            Assert.AreEqual(true, result.ViewData.ModelState.IsValid);
        }


    }
}
