--SELECT FilmName FROM HorrorMoviesTable
--WHERE Creators='Warner Bros. (Warner Bros. Pictures)' AND Subtitles='True';
--SELECT FilmName FROM HorrorMoviesTable
--WHERE Evaluation BETWEEN 1.0 AND 3.0
--SELECT FilmName FROM HorrorMoviesTable
--WHERE Creators='Warner Bros. (Warner Bros. Pictures)'

SELECT FilmName,
   CASE 
    WHEN Evaluation BETWEEN 1.0 AND 3.0 AND Creators='Warner Bros. (Warner Bros. Pictures)'  THEN FilmName
	 WHEN   Evaluation BETWEEN 3.0 AND 5.0 AND Creators='Warner Bros. (Warner Bros. Pictures)'    THEN FilmName
	 WHEN Subtitles ='False'THEN 'nera titru'
	 ELSE 'ne'
	END
FROM HorrorMoviesTable