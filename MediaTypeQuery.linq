<Query Kind="Statements">
  <Connection>
    <ID>ce18096e-dd65-4517-945a-9cc00d47d200</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
              {
                 Name= m.Name,
                 Tracks = from t in m.Tracks
				          select new
				{
				   TrackName = t.Name,
				   Album = t.Album.Title,
				   Artist = t.Album.Artist.Name,
				   ReleaseYear = t.Album.ReleaseYear,
				   ReleaseLabel = t.Album.ReleaseLabel,
				   Genre = t. Genre.Name
				 }
              };
results.Dump();