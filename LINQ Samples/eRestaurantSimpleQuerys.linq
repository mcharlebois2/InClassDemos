<Query Kind="Statements">
  <Connection>
    <ID>76818d6e-29ad-4255-ae9d-a0a4f1985ed7</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//step 1 connect to the desired database
	//click on add connection
	//take defaults
	//change server to "." and select existing database from list
	//optionally test connection
	//press ok
	
	//remember to check the connection dropdown list!!
	
	//result should show the database tables in the connection object area.
	//expanding a table will reveal the table attributes and any table relationships
	
	//view waiter data
	
	Waiters
	
	//query syntax to also view Waiter data
	from item in Waiters
	select item
	//the "item" in the statement can be anything (make it meaningful), it's the input parameter
	//method syntax (hit the lamda button)
	Waiters.Select (item => item)
	
	//alter the query syntax into a C# statemtent
	var results = from item in Waiters
	select item;
	results.Dump();

	
	//once the query is created, tested, you will be able to
	//transfer the query to with minor modifications into your
	//BLL methods
	//public List<pocoObject> SomeBLLMethodName()
	//{
		//connect to DAL object : var contextvariable
		//do your query
		//var results = from item in contextvariable.Waiters
		//select item;
		//return results.ToList();
		
	//}






