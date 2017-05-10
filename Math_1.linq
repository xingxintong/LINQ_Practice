<Query Kind="Statements">
  <Connection>
    <ID>ce18096e-dd65-4517-945a-9cc00d47d200</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			    Genre = g.Name,
				TracksCount = g.Tracks.Count()
			};
results.Dump("Query Math 1");