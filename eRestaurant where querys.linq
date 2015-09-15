<Query Kind="Expression">
  <Connection>
    <ID>76818d6e-29ad-4255-ae9d-a0a4f1985ed7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//where clause

//list all tables that more than three people.
from row in Tables
where row.Capacity > 3
select row


//list all items that have more than 500 calories.
from item in Items
where item.Calories > 500
select item

//list all items that have more than 500 calories and sells for more than 10 dollars
from item in Items
where item.Calories > 500 &&
item.CurrentPrice > 10.00m
select item

//list all items that have more than 500 calories and are Entrees on the menu
//HINT: navigational properties of the database and LINQPad knowledge
from item in Items
where item.Calories > 500 &&
item.MenuCategory.Description.Equals("Entree")
select item


