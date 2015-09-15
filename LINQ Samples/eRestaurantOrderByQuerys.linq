<Query Kind="Expression">
  <Connection>
    <ID>76818d6e-29ad-4255-ae9d-a0a4f1985ed7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//orderby

//default acending
from food in Items
orderby food.Description
select food

//decending
from food in Items
orderby food.CurrentPrice descending
select food

//both
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
select food

from food in Items
where food.MenuCategory.Description.Equals("Entree")
orderby food.CurrentPrice descending, food.Calories ascending
select food