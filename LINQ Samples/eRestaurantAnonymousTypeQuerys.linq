<Query Kind="Program">
  <Connection>
    <ID>76818d6e-29ad-4255-ae9d-a0a4f1985ed7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	Waiters.Dump();
	////anonymous datatype structures
	//from food in Items
	//where food.MenuCategory.Description.Equals("Entree") &&
	//food.Active
	//orderby food.CurrentPrice descending
	//select new
	//{
	//	Descreiption = food.Description,
	//	Price = food.CurrentPrice,
	//	Cost = food.CurrentCost,
	//	Profit = food.CurrentPrice - food.CurrentCost
	//}
	//
	//
	//from food in Items
	//where food.MenuCategory.Description.Equals("Entree") &&
	//food.Active
	//orderby food.CurrentPrice descending
	//select new
	//{
	//	food.Description,
	//	food.CurrentPrice,
	//	food.CurrentCost,
	//	
	//}
	
	//type query set
	var results = from food in Items
		where food.MenuCategory.Description.Equals("Entree") &&
		food.Active
		orderby food.CurrentPrice descending
		select new FoodMargin()
		{
			Description = food.Description,
			Price = food.CurrentPrice,
			Cost = food.CurrentCost,
			Profit = food.CurrentPrice - food.CurrentCost
		};
		
		results.Dump();
		
		var results2 = from orders in Bills
			where orders.PaidStatus &&
				(orders.BillDate.Month == 9 && orders.BillDate.Year == 2014)
			orderby orders.Waiter.LastName, orders.Waiter.FirstName
			select new BillOrders()
			{
				BillID = orders.BillID,
				Waiter = orders.Waiter.LastName + ", " + orders.Waiter.FirstName,
				Orders = orders.BillItems
			};
			
			results2.Dump();
		
		
	
	//Define other methods and classes here
	//Sample of a POCO type class 
	
}

// Define other methods and classes here

//POCO!!
public class FoodMargin
	{
		public string Description{get; set;}
		public decimal Price{get; set;}
		public decimal Cost{get; set;}
		public decimal Profit{get; set;}
	}
	

//DTO!!
public class BillOrders
	{
		public int BillID{get; set;}
		public string Waiter{get; set;}
		public IEnumerable Orders{get; set;}
		
	}
	
