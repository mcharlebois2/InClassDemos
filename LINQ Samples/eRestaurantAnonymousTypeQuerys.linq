<Query Kind="Expression">
  <Connection>
    <ID>76818d6e-29ad-4255-ae9d-a0a4f1985ed7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous datatype structures
from food in Items
where food.MenuCategory.Description.Equals("Entree") &&
food.Active
orderby food.CurrentPrice descending
select new
{
	Descreiption = food.Description,
	Price = food.CurrentPrice,
	Cost = food.CurrentCost,
	Profit = food.CurrentPrice - food.CurrentCost
}


from food in Items
where food.MenuCategory.Description.Equals("Entree") &&
food.Active
orderby food.CurrentPrice descending
select new
{
	food.Description,
	food.CurrentPrice,
	food.CurrentCost,
	
}
