<Query Kind="Expression">
  <Connection>
    <ID>76818d6e-29ad-4255-ae9d-a0a4f1985ed7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Grouping
from food in Items
group food by food.MenuCategory.Description

//requires the creation of an anonymous type
from food in Items
group food by new {food.MenuCategory.Description, food.CurrentPrice}