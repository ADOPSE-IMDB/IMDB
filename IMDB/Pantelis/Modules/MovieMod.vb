﻿Imports System.Data

Module MovieMod
    Public Function TestMovieMod() 'A function for testing all the above functions
        Console.WriteLine("**********Testing Methods of MovieMod**********")

        Console.WriteLine("CountMovies() returns:")
        Console.WriteLine(CountMovies())

        Console.WriteLine("GetAllMovies() returns:")
        Dim allMovies() As Movie
        allMovies = MovieMod.GetAllMovies()
        For i = 0 To allMovies.Length - 1
            allMovies(i).Print()
        Next

        Console.WriteLine("GetMoviesFromTo() returns:")
        Dim fromToMovies() As Movie
        fromToMovies = MovieMod.GetMoviesFromTo(2, 5)
        For i = 0 To fromToMovies.Length - 1
            fromToMovies(i).Print()
        Next

        Console.WriteLine("GetTopMovies() returns:")
        Dim topMovies() As Movie
        topMovies = MovieMod.GetTopMovies()
        For i = 0 To topMovies.Length - 1
            topMovies(i).Print()
        Next
    End Function
    Public Function CountMovies()   'a function that returns the number of movies in the database
        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select count(*) as num from Movies", results)

        Return results.Rows(0)("num").ToString()
    End Function
    Public Function GetAllMovies()  'a function that returns a table of Movie objects with all the movies
        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select * from Movies", results)

        Dim numberOfMovies As New Integer
        numberOfMovies = CountMovies()

        Dim allMovies(numberOfMovies - 1) As Movie  'numberOfMovies : number of movies (-1 size of the Array)

        For i = 0 To allMovies.Length - 1
            allMovies(i) = New Movie With {
                .Id = results.Rows(i)("id").ToString,
                .Title = results.Rows(i)("title").ToString,
                .Year = results.Rows(i)("year").ToString,
                .Description = results.Rows(i)("description").ToString,
                .Rating = results.Rows(i)("rating").ToString,
                .Url = results.Rows(i)("image_url").ToString
            }
        Next

        Return allMovies
    End Function
    Public Function GetMoviesFromTo(ByVal fromNum As Integer, ByVal toNum As Integer)   'a function with number parameters that returns a table of Movie objects with the movies from the first parameter to the second 
        Dim args() As String = {fromNum, toNum}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select * from Movies where id between @0 and @1", args, results)

        Dim fromToMovies(toNum - fromNum) As Movie    'toNum - fromNum : number of movies (-1 size of the Array)

        For i = 0 To fromToMovies.Length - 1
            fromToMovies(i) = New Movie With {
                .Id = results.Rows(i)("id").ToString,
                .Title = results.Rows(i)("title").ToString,
                .Year = results.Rows(i)("year").ToString,
                .Description = results.Rows(i)("description").ToString,
                .Rating = results.Rows(i)("rating").ToString,
                .Url = results.Rows(i)("image_url").ToString
            }

        Next

        Return fromToMovies
    End Function
    Public Function GetTopMovies()  'a function that returns a table of Movie objects with the top 10 movies
        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select * from Movies order by rating DESC limit 10", results)


        Dim topMovies(10 - 1) As Movie  '10 : number of movies (-1 size of the Array)

        For i = 0 To topMovies.Length - 1
            topMovies(i) = New Movie With {
                .Id = results.Rows(i)("id").ToString,
                .Title = results.Rows(i)("title").ToString,
                .Year = results.Rows(i)("year").ToString,
                .Description = results.Rows(i)("description").ToString,
                .Rating = results.Rows(i)("rating").ToString,
                .Url = results.Rows(i)("image_url").ToString
            }
        Next

        Return topMovies
    End Function

    Public Function RateMovie(ByVal movieID, ByVal userID, ByVal rating)
        Dim flag As Boolean = False

        Dim con As New Connection
        Dim args() As String = {movieID, userID, rating}
        Dim results As New DataTable
        con.RunQuery("Insert into UserRating(movie_id,user_id,rating) values (@0,@1,@2)", args, results)
        flag = True
        Return flag
    End Function

End Module
