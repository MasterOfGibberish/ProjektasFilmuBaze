ALTER PROC FilmAdd


@FilmName varchar(50),
@Creators varchar(50),
@Evaluation decimal(18, 0),
@Decade int,
@Subtitles varchar(50)
AS 
   INSERT INTO HorrorMoviesTable ( FilmName, Creators, Evaluation, Decade, Subtitles)
   VALUES ( @FilmName, @Creators, @Evaluation, @Decade, @Subtitles)

