<Query Kind="Statements">
  <Connection>
    <ID>ce18096e-dd65-4517-945a-9cc00d47d200</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new
			  {
				TracksCount = g.Tracks.Count(),
				Tracks = from t in g.Tracks
				         select new
				{
				   TrackName = t.Name,
				   AlbumName = t.Album.Title,
				   Milliseconds = t.Milliseconds,
				   Size = (t.Bytes/1000)+"kb",
				   Price = t.UnitPrice
				}
			};
results.Dump("Query Math 2");