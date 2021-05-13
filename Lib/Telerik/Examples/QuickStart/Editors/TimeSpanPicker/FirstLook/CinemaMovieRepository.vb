﻿Imports System
Imports System.Collections.Generic

Namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
    Module CinemaMovieRepository
        Function LoadMovies() As IList(Of CinemaMovieInfo)
            Dim movies As IList(Of CinemaMovieInfo) = New List(Of CinemaMovieInfo)()
            movies.Add(New CinemaMovieInfo With {
                .Title = "The Godfather",
                .StartTime = DateTime.Today.AddHours(9.5),
                .EndTime = DateTime.Today.AddHours(11),
                .Genre = "crime",
                .GenreIcon = My.Resources.crime_purple,
                .StartFilmingDate = New DateTime(1971, 3, 29),
                .ReleaseDate = New DateTime(1972, 1, 1),
                .Description = "The Godfather is a 1972 American epic crime film directed by Francis Ford Coppola and starring Marlon Brando and Al Pacino." & vbCrLf & vbCrLf & "Most of the principal photography took place from March 29, 1971 to August 6, 1971, although a scene with Pacino and Keaton was shot in the autumn. There were a total of 77 days of shooting, fewer than the 83 for which the production had budgeted."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "The Sting",
                .StartTime = DateTime.Today.AddHours(10.25),
                .EndTime = DateTime.Today.AddHours(13.25),
                .Genre = "comedy",
                .GenreIcon = My.Resources.comedy_blue,
                .StartFilmingDate = New DateTime(1973, 1, 1),
                .ReleaseDate = New DateTime(1973, 12, 25),
                .Description = "The Sting is a 1973 American caper film set in September 1936 that involves a complicated plot by two professional grifters (Paul Newman and Robert Redford) to con a mob boss (Robert Shaw)."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Chinatown",
                .StartTime = DateTime.Today.AddHours(10.5),
                .EndTime = DateTime.Today.AddHours(11.75),
                .Genre = "crime drama",
                .GenreIcon = My.Resources.drama_blue,
                .StartFilmingDate = New DateTime(1974, 1, 1),
                .ReleaseDate = New DateTime(1974, 12, 31),
                .Description = "Chinatown is a 1974 American neo-noir film, directed by Roman Polanski from a screenplay by Robert Towne and starring Jack Nicholson, Faye Dunaway and John Huston."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Jaws",
                .StartTime = DateTime.Today.AddHours(11.75),
                .EndTime = DateTime.Today.AddHours(14),
                .Genre = "thriller",
                .GenreIcon = My.Resources.thriller_blue,
                .StartFilmingDate = New DateTime(1974, 10, 6),
                .ReleaseDate = New DateTime(1975, 3, 15),
                .Description = "Jaws is a 1975 American thriller film directed by Steven Spielberg. Shot mostly on location on Martha's Vineyard, Massachusetts, the film had a troubled production, going over budget and past schedule." & vbCrLf & vbCrLf & "Although principal photography wass scheduled to take 55 days, it did not wrap until October 6, 1974, after 159 days."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Rocky",
                .StartTime = DateTime.Today.AddHours(12),
                .EndTime = DateTime.Today.AddHours(13.5),
                .Genre = "drama",
                .GenreIcon = My.Resources.drama_green,
                .StartFilmingDate = New DateTime(1976, 1, 1),
                .ReleaseDate = New DateTime(1976, 12, 31),
                .Description = "Rocky is a 1976 American sports drama film directed by John G. Avildsen and both written by and starring Sylvester Stallone who plays the character Rocky Balboa."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Star Wars",
                .StartTime = DateTime.Today.AddHours(12.5),
                .EndTime = DateTime.Today.AddHours(15),
                .Genre = "epic",
                .GenreIcon = My.Resources.epic_blue,
                .StartFilmingDate = New DateTime(1977, 1, 1),
                .ReleaseDate = New DateTime(1983, 12, 31),
                .Description = "Star Wars Episode I: The Phantom Menace is a 1999 American epic space opera film written and directed by George Lucas." & vbCrLf & vbCrLf & "Filming began on June 26, 1997 and ended on September 30 of that year, primarily taking place at Leavesden Film Studios in England, with additional location shooting in the Tunisian desert for the Tatooine scenes, Cassiobury Park in Watford, England for the forest scenes on Naboo and the Italian Caserta Palace for the Theed City Naboo Palace interior."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Life of Brian",
                .StartTime = DateTime.Today.AddHours(12.75),
                .EndTime = DateTime.Today.AddHours(14.25),
                .Genre = "comedy",
                .GenreIcon = My.Resources.comedy_purple,
                .StartFilmingDate = New DateTime(1979, 1, 1),
                .ReleaseDate = New DateTime(1979, 8, 17),
                .Description = "Life of Brian, is a 1979 British comedy film written, directed and largely performed by the Monty Python comedy team. Starring: Graham Chapman, John Cleese, Terry Gilliam, Eric Idle, Terry Jones, Michael Palin."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "The Shining",
                .StartTime = DateTime.Today.AddHours(13.25),
                .EndTime = DateTime.Today.AddHours(16),
                .Genre = "horror",
                .GenreIcon = My.Resources.horror_green,
                .StartFilmingDate = New DateTime(1980, 1, 1),
                .ReleaseDate = New DateTime(1980, 12, 31),
                .Description = "The Shining is a 1980 psychological horror film produced and directed by Stanley Kubrick, co-written with novelist Diane Johnson, and starring Jack Nicholson, Shelley Duvall, Scatman Crothers, and Danny Lloyd. The film is based on the novel of the same name by Stephen King."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Raiders of the Lost Ark",
                .StartTime = DateTime.Today.AddHours(14),
                .EndTime = DateTime.Today.AddHours(17.5),
                .Genre = "action – adventure",
                .GenreIcon = My.Resources.adventure_green,
                .StartFilmingDate = New DateTime(1980, 6, 23),
                .ReleaseDate = New DateTime(1981, 6, 12),
                .Description = "Raiders of the Lost Ark (also known as Indiana Jones and the Raiders of the Lost Ark) is a 1981 American action-adventure film directed by Steven Spielberg, produced by George Lucas, and starring Harrison Ford."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Beverly Hills Cop",
                .StartTime = DateTime.Today.AddHours(14.75),
                .EndTime = DateTime.Today.AddHours(16),
                .Genre = "comedy",
                .GenreIcon = My.Resources.comedy_blue,
                .StartFilmingDate = New DateTime(1984, 1, 1),
                .ReleaseDate = New DateTime(1984, 12, 5),
                .Description = "Beverly Hills Cop is a 1984 American comedy-action film directed by Martin Brest and starring Eddie Murphy, Lisa Eilbacher, John Ashton, Judge Reinhold, and Ronny Cox. The film was released on December 5 and was very anticipated."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "The Terminator",
                .StartTime = DateTime.Today.AddHours(15),
                .EndTime = DateTime.Today.AddHours(16.5),
                .Genre = "action",
                .GenreIcon = My.Resources.action_blue,
                .StartFilmingDate = New DateTime(1984, 2, 1),
                .ReleaseDate = New DateTime(1984, 10, 26),
                .Description = "The Terminator is a 1984 American science fiction action film directed by James Cameron, co-written by Cameron and William Wisher Jr. and starring Arnold Schwarzenegger, Michael Biehn, and Linda Hamilton. In March 1984, the film began production in Los Angeles."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Full Metal Jacket",
                .StartTime = DateTime.Today.AddHours(15.5),
                .EndTime = DateTime.Today.AddHours(17.75),
                .Genre = "war",
                .GenreIcon = My.Resources.war_blue,
                .StartFilmingDate = New DateTime(1987, 1, 1),
                .ReleaseDate = New DateTime(1987, 6, 26),
                .Description = "Full Metal Jacket is a 1987 war film produced, directed and co-written by Stanley Kubrick. It is an adaptation of the 1979 novel The Short-Timers by Gustav Hasford and stars Matthew Modine, Vincent D'Onofrio, R. Lee Ermey, Arliss Howard and Adam Baldwin. Kubrick shot the film in England."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Die Hard",
                .StartTime = DateTime.Today.AddHours(14),
                .EndTime = DateTime.Today.AddHours(15.5),
                .Genre = "action",
                .GenreIcon = My.Resources.action_green,
                .StartFilmingDate = New DateTime(1988, 1, 1),
                .ReleaseDate = New DateTime(1988, 7, 15),
                .Description = "Die Hard is a 1988 American action film directed by John McTiernan and stars Bruce Willis, Alan Rickman , Alexander Godunov, Bonnie Bedelia ."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Nuovo Cinema Paradiso",
                .StartTime = DateTime.Today.AddHours(14.75),
                .EndTime = DateTime.Today.AddHours(16.5),
                .Genre = "drama",
                .GenreIcon = My.Resources.drama_purple,
                .StartFilmingDate = New DateTime(1988, 1, 1),
                .ReleaseDate = New DateTime(1988, 11, 7),
                .Description = "Nuovo cinema Paradiso is a 1988 Italian drama film written and directed by Giuseppe Tornatore  and  stars  Jacques Perrin, Philippe Noiret, Leopoldo Trieste, Marco Leonardi, Agnese Nano and Salvatore Cascio."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Indiana Jones and the Last Crusade",
                .StartTime = DateTime.Today.AddHours(16),
                .EndTime = DateTime.Today.AddHours(17),
                .Genre = "action – adventure",
                .GenreIcon = My.Resources.adventure_purple,
                .StartFilmingDate = New DateTime(1988, 6, 2),
                .ReleaseDate = New DateTime(1989, 5, 24),
                .Description = "Indiana Jones and the Last Crusade is a 1989 American adventure film directed by Steven Spielberg and the stars Harrison Ford, Sean Connery etc." & vbCrLf & vbCrLf & "Principal photography began on May 16, 1988 in the Tabernas Desert in the Almería province of Spain. - The closing shot of Indiana, Henry, Sallah and Brody riding into the sunset was filmed in Texas in early 1989."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Batman",
                .StartTime = DateTime.Today.AddHours(15.5),
                .EndTime = DateTime.Today.AddHours(17),
                .Genre = "superhero",
                .GenreIcon = My.Resources.superhero_green,
                .StartFilmingDate = New DateTime(1988, 10, 1),
                .ReleaseDate = New DateTime(1989, 6, 23),
                .Description = "Batman is a 1989 American superhero film directed by Tim Burton and stars Jack Nicholson, Michael Keaton, Kim Basinger, Robert Wuhl, Pat Hingle, Billy Dee Williams, Michael Gough, Jack Palance Principal photography  began from October 1988 to January 1989."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Goodfellas",
                .StartTime = DateTime.Today.AddHours(16),
                .EndTime = DateTime.Today.AddHours(18.5),
                .Genre = "crime",
                .GenreIcon = My.Resources.crime_purple,
                .StartFilmingDate = New DateTime(1990, 1, 1),
                .ReleaseDate = New DateTime(1990, 12, 31),
                .Description = "GoodFellas is a 1990 American crime film directed by Martin Scorsese. Starring - Ray Liotta,Robert De Niro,Joe Pesci,Lorraine Bracco, Paul Sorvino. The film was shot on location in Queens, New York, New Jersey, and parts of Long Island during the spring and summer of 1989."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Terminator 2: Judgment Day",
                .StartTime = DateTime.Today.AddHours(16.5),
                .EndTime = DateTime.Today.AddHours(18),
                .Genre = "action",
                .GenreIcon = My.Resources.action_purple,
                .StartFilmingDate = New DateTime(1990, 10, 9),
                .ReleaseDate = New DateTime(1991, 4, 4),
                .Description = "Terminator 2: Judgment Day is a 1991 science fiction action film, the second installment of the Terminator franchise and the sequel to The Terminator (1984). Directed by James Cameron. Principal photography of Terminator 2 spanned over 186 days between October 9, 1990 and April 4, 1991"
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Unforgiven",
                .StartTime = DateTime.Today.AddHours(16.75),
                .EndTime = DateTime.Today.AddHours(18.5),
                .Genre = "western",
                .GenreIcon = My.Resources.western_green,
                .StartFilmingDate = New DateTime(1992, 1, 1),
                .ReleaseDate = New DateTime(1992, 8, 7),
                .Description = "Unforgiven is a 1992 American Western film produced and directed by Clint Eastwood. Starring: Clint Eastwood, Gene Hackman, Morgan Freeman, Richard Harris."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Jurassic Park",
                .StartTime = DateTime.Today.AddHours(17.5),
                .EndTime = DateTime.Today.AddHours(19.75),
                .Genre = "adventure thriller",
                .GenreIcon = My.Resources.thriller_blue,
                .StartFilmingDate = New DateTime(1992, 8, 24),
                .ReleaseDate = New DateTime(1993, 6, 11),
                .Description = "Jurassic Park is a 1993 American science fiction adventure thriller film directed by Steven Spielberg. It stars Sam Neill, Laura Dern, Jeff Goldblum etc." & vbCrLf & vbCrLf & "After 25 months of pre-production, filming began on August 24, 1992, on the Hawaiian island of Kauaʻi. On September 11, Hurricane Iniki passed directly over Kauaʻi, which caused the crew to lose a day of shooting.  Several of the storm scenes from the CinemaMovieInfo are actual footage shot during the hurricane."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Forrest Gump",
                .StartTime = DateTime.Today.AddHours(18),
                .EndTime = DateTime.Today.AddHours(21),
                .Genre = "comedy drama romance",
                .GenreIcon = My.Resources.drama_blue,
                .StartFilmingDate = New DateTime(1994, 1, 1),
                .ReleaseDate = New DateTime(1994, 7, 6),
                .Description = "Forrest Gump is a 1994 American epic comedy-drama romance film. The film was directed by Robert Zemeckis, starring Tom Hanks, Robin Wright and Gary Sinise.  Filming began in August 1993 and ended four months later in December."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Twelve Monkeys",
                .StartTime = DateTime.Today.AddHours(18.5),
                .EndTime = DateTime.Today.AddHours(20),
                .Genre = "science fiction",
                .GenreIcon = My.Resources.science_blue,
                .StartFilmingDate = New DateTime(1995, 2, 8),
                .ReleaseDate = New DateTime(1995, 12, 29),
                .Description = "12 Monkeys is a 1995 science fiction film directed by Terry Gilliam and starring Bruce Willis, Madeleine Stowe, and Brad Pitt."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "La vita è bella",
                .StartTime = DateTime.Today.AddHours(18.75),
                .EndTime = DateTime.Today.AddHours(21.5),
                .Genre = "drama",
                .GenreIcon = My.Resources.drama_green,
                .StartFilmingDate = New DateTime(1997, 8, 10),
                .ReleaseDate = New DateTime(1998, 10, 23),
                .Description = "Life Is Beautiful (Italian: La vita è bella) is a 1997 Italian film which tells the story of a Jewish Italian directed by Roberto Benigni. Starring:" & vbTab & "Roberto Benigni, Nicoletta Braschi, Giorgio Cantarini, Giustino Durano, Sergio Bini Bustric."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Saving Private Ryan",
                .StartTime = DateTime.Today.AddHours(19.5),
                .EndTime = DateTime.Today.AddHours(21),
                .Genre = "war",
                .GenreIcon = My.Resources.war_green,
                .StartFilmingDate = New DateTime(1998, 1, 1),
                .ReleaseDate = New DateTime(1998, 7, 24),
                .Description = "Saving Private Ryan is a 1998 American epic war film set during the invasion of Normandy in World War II. It was directed by Steven Spielberg and written by Robert Rodat."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "American Beauty",
                .StartTime = DateTime.Today.AddHours(20),
                .EndTime = DateTime.Today.AddHours(23),
                .Genre = "drama",
                .GenreIcon = My.Resources.drama_purple,
                .StartFilmingDate = New DateTime(1998, 12, 14),
                .ReleaseDate = New DateTime(1999, 9, 17),
                .Description = "American Beauty is a 1999 American drama film directed by Sam Mendes and written by Alan Ball. Starring: Kevin Spacey, Annette Bening, Thora Birch, Wes Bentley, Mena Suvari, Chris Cooper, Allison Janney. Principal photography lasted about 50 days  from December 14, 1998 to February 1999."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Star Wars Episode I",
                .StartTime = DateTime.Today.AddHours(20.25),
                .EndTime = DateTime.Today.AddHours(22),
                .Genre = "epic",
                .GenreIcon = My.Resources.epic_green,
                .StartFilmingDate = New DateTime(1997, 6, 26),
                .ReleaseDate = New DateTime(1999, 1, 1),
                .Description = "Star Wars Episode I: The Phantom Menace is a 1999 American epic space opera film written and directed by George Lucas. It is the fourth film to be released in the Star Wars saga, as the first of a three-part prequel to the original Star Wars trilogy, as well as the first film in the saga in terms of story chronology." & vbCrLf & vbCrLf & "Within three to four months of Lucas beginning the writing process, Doug Chiang and his design team started a two-year process of reviewing thousands of designs for the film." & vbCrLf & vbCrLf & "Filming began on June 26, 1997 and ended on September 30 of that year, primarily taking place at Leavesden Film Studios in England, with additional location shooting in the Tunisian desert for the Tatooine scenes, Cassiobury Park in Watford, England for the forest scenes on Naboo and the Italian Caserta Palace for the Theed City Naboo Palace interior. "
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Gladiator",
                .StartTime = DateTime.Today.AddHours(20.25),
                .EndTime = DateTime.Today.AddHours(22.5),
                .Genre = "historical epic",
                .GenreIcon = My.Resources.epic_purple,
                .StartFilmingDate = New DateTime(1999, 1, 1),
                .ReleaseDate = New DateTime(2000, 5, 5),
                .Description = "Gladiator is a 2000 historical epic film directed by Ridley Scott, starring Russell Crowe, Joaquin Phoenix, Connie Nielsen, Ralf Möller, Oliver Reed, Djimon Hounsou, Derek Jacobi, John Shrapnel and Richard Harris. The film was shot in three main locations between January and May 1999."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "A Beautiful Mind",
                .StartTime = DateTime.Today.AddHours(20.75),
                .EndTime = DateTime.Today.AddHours(22.5),
                .Genre = "biographical drama",
                .GenreIcon = My.Resources.drama_blue,
                .StartFilmingDate = New DateTime(2001, 1, 1),
                .ReleaseDate = New DateTime(2001, 12, 21),
                .Description = "A Beautiful Mind is a 2001 American biographical drama film based on the life of John Nash, a Nobel Laureate in Economics. The film was directed by Ron Howard and written by Akiva Goldsman. The film stars Russell Crowe, along with Ed Harris, Jennifer Connelly, Paul Bettany and Christopher Plummer."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Shrek",
                .StartTime = DateTime.Today.AddHours(21),
                .EndTime = DateTime.Today.AddHours(24),
                .Genre = "animated fantasy comedy",
                .GenreIcon = My.Resources.animation_blue,
                .StartFilmingDate = New DateTime(2001, 1, 1),
                .ReleaseDate = New DateTime(2001, 5, 18),
                .Description = "Shrek is a 2001 American computer-animated fantasy comedy film directed by Andrew Adamson and Vicky Jenson, featuring the voices of Mike Myers, Eddie Murphy, Cameron Diaz, and John Lithgow."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Spider-Man",
                .StartTime = DateTime.Today.AddHours(21.25),
                .EndTime = DateTime.Today.AddHours(23),
                .Genre = "superhero",
                .GenreIcon = My.Resources.superhero_purple,
                .StartFilmingDate = New DateTime(2001, 6, 1),
                .ReleaseDate = New DateTime(2002, 5, 3),
                .Description = "Spider-Man is a 2002 American superhero film directed by Sam Raimi and written by David Koepp. Starring: Tobey Maguire, Willem Dafoe, Kirsten Dunst, James Franco, Cliff Robertson, Rosemary Harris, J. K. Simmons Filming took place in California and New York City from January to June 2001."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Pirates of the Caribbean 1",
                .StartTime = DateTime.Today.AddHours(21.5),
                .EndTime = DateTime.Today.AddHours(24.5),
                .Genre = "adventure fantasy",
                .GenreIcon = My.Resources.adventure_green,
                .StartFilmingDate = New DateTime(2002, 10, 9),
                .ReleaseDate = New DateTime(2003, 7, 9),
                .Description = "Pirates of the Caribbean: The Curse of the Black Pearl is a 2003 American adventure fantasy film. It was directed by Gore Verbinski and produced by Jerry Bruckheimer. Starring - Johnny Depp, Geoffrey Rush, Orlando Bloom, Keira Knightley, Jonathan Pryce. Shooting began on October 9, 2002 and wrapped by March 2003."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Kill Bill",
                .StartTime = DateTime.Today.AddHours(21.75),
                .EndTime = DateTime.Today.AddHours(23.25),
                .Genre = "drama",
                .GenreIcon = My.Resources.drama_green,
                .StartFilmingDate = New DateTime(2003, 1, 1),
                .ReleaseDate = New DateTime(2003, 10, 10),
                .Description = "Kill Bill: Volume 1 is a 2003 American action/thriller film written and directed by Quentin Tarantino. Starring:" & vbTab & "Uma Thurman, Lucy Liu, Vivica A. Fox, Daryl Hannah, David Carradine, Michael Madsen, Julie Dreyfus."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Shrek 2",
                .StartTime = DateTime.Today.AddHours(22),
                .EndTime = DateTime.Today.AddHours(24),
                .Genre = "computer-animated fantasy comedy",
                .GenreIcon = My.Resources.animation_green,
                .StartFilmingDate = New DateTime(2004, 1, 1),
                .ReleaseDate = New DateTime(2004, 5, 19),
                .Description = "Shrek 2 is a 2004 American computer-animated fantasy comedy film, produced by DreamWorks Animation and directed by Andrew Adamson, Kelly Asbury and Conrad Vernon."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Spider-Man 2",
                .StartTime = DateTime.Today.AddHours(22.25),
                .EndTime = DateTime.Today.AddHours(23.75),
                .Genre = "superhero",
                .GenreIcon = My.Resources.superhero_green,
                .StartFilmingDate = New DateTime(2003, 4, 12),
                .ReleaseDate = New DateTime(2004, 6, 30),
                .Description = "Spider-Man 2 is a 2004 American superhero film directed by Sam Raimi . Starring : Tobey Maguire, Kirsten Dunst, James Franco etc." & vbCrLf & vbCrLf & "Spider-Man 2 was shot on over 100 sets and locations, beginning with a pre-shoot on the Loop in Chicago during two days in November 2002. Principal photography began on April 12, 2003 in New York City. The crew moved on May 13 to Los Angeles."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Batman Begins",
                .StartTime = DateTime.Today.AddHours(22.5),
                .EndTime = DateTime.Today.AddHours(24.5),
                .Genre = "superhero",
                .GenreIcon = My.Resources.superhero_purple,
                .StartFilmingDate = New DateTime(2004, 3, 1),
                .ReleaseDate = New DateTime(2005, 6, 15),
                .Description = "Batman Begins is a 2005 superhero film based on the fictional DC Comics character Batman, directed by Christopher Nolan." & vbCrLf & "It stars Christian Bale as Batman, along with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman, Cillian Murphy, Morgan Freeman, Ken Watanabe, Tom Wilkinson, and Rutger Hauer."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Pirates of the Caribbean 2",
                .StartTime = DateTime.Today.AddHours(22.75),
                .EndTime = DateTime.Today.AddHours(24.5),
                .Genre = "adventure fantasy",
                .GenreIcon = My.Resources.adventure_purple,
                .StartFilmingDate = New DateTime(2005, 9, 10),
                .ReleaseDate = New DateTime(2006, 7, 7),
                .Description = "Pirates of the Caribbean: Dead Man's Chest is a 2006 American adventure fantasy film. It was directed by Gore Verbinski and produced by Jerry Bruckheimer . Starring: Johnny Depp, Orlando Bloom, Keira Knightley etc." & vbCrLf & vbCrLf & "Filming  began on February 28, 2005 in Palos Verdes . On April 18,  2005, the crew began shooting at Dominica. On September 18, 2005, the crew moved to Grand Bahama Island to shoot ship exteriors, including the working Black Pearl and Flying Dutchman.Filming completed on September 10, 2005."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Pirates of the Caribbean 3",
                .StartTime = DateTime.Today.AddHours(23),
                .EndTime = DateTime.Today.AddHours(24.5),
                .Genre = "adventure fantasy",
                .GenreIcon = My.Resources.adventure_green,
                .StartFilmingDate = New DateTime(2006, 8, 3),
                .ReleaseDate = New DateTime(2007, 5, 25),
                .Description = "Pirates of the Caribbean: At World's End is a 2007 American adventure fantasy film, the third film in the Pirates of the Caribbean series." & vbCrLf & vbCrLf & "Parts of the third film were shot during location filming of Pirates of the Caribbean: Dead Man's Chest, a long shoot which finished on March 1, 2006. Filming resumed on August 3, 2006 at the Bonneville Salt Flats in Utah. Filming finished on December 12, 2006 in Molokai."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Slumdog Millionaire",
                .StartTime = DateTime.Today.AddHours(23.25),
                .EndTime = DateTime.Today.AddHours(25.5),
                .Genre = "drama",
                .GenreIcon = My.Resources.drama_purple,
                .StartFilmingDate = New DateTime(2007, 11, 5),
                .ReleaseDate = New DateTime(2008, 10, 12),
                .Description = "Slumdog Millionaire is a 2008 British drama film directed by Danny Boyle, written by Simon Beaufoy, and co-directed in India by Loveleen Tandan. Starring - Dev Patel, Freida Pinto, Mahesh Manjrekar, Madhur Mittal, Anil Kapoor."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Inglourious Basterds",
                .StartTime = DateTime.Today.AddHours(23.5),
                .EndTime = DateTime.Today.AddHours(25),
                .Genre = "war",
                .GenreIcon = My.Resources.war_green,
                .StartFilmingDate = New DateTime(2008, 10, 13),
                .ReleaseDate = New DateTime(2009, 5, 20),
                .Description = "Inglourious Basterds is a 2009 war film written and directed by Quentin Tarantino and starring Brad Pitt, Christoph Waltz and Mélanie Laurent. Filming was scheduled to begin on October 13, 2008, and shooting started that week in Germany."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Inception",
                .StartTime = DateTime.Today.AddHours(23.5),
                .EndTime = DateTime.Today.AddHours(25.5),
                .Genre = "science action",
                .GenreIcon = My.Resources.science_purple,
                .StartFilmingDate = New DateTime(2009, 6, 19),
                .ReleaseDate = New DateTime(2010, 3, 26),
                .Description = "Inception is a 2010 science fiction action heist film which was written, co-produced, and directed by Christopher Nolan.  Starring:  Leonardo DiCaprio, Ken Watanabe, Joseph Gordon-Levitt, Marion Cotillard, Ellen Page, Tom Hardy." & vbCrLf & vbCrLf & "Principal photography began in Tokyo on June 19, 2009 . The final phase of principal photography took place in Alberta in late November 2009."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "How to Train Your Dragon",
                .StartTime = DateTime.Today.AddHours(23.75),
                .EndTime = DateTime.Today.AddHours(25.25),
                .Genre = "animation",
                .GenreIcon = My.Resources.animation_blue,
                .StartFilmingDate = New DateTime(2004, 11, 5),
                .ReleaseDate = New DateTime(2010, 3, 26),
                .Description = "How to Train Your Dragon is a 2010 3D computer-animated fantasy film by DreamWorks Animation loosely based on the English 2003 book of the same name." & vbCrLf & vbCrLf & "The film was directed by Chris Sanders and Dean DeBlois The book series by Cressida Cowell began coming to attention to the executives at Dreamworks Animation in 2004."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Intouchables",
                .StartTime = DateTime.Today.AddHours(24),
                .EndTime = DateTime.Today.AddHours(25.5),
                .Genre = "comedy",
                .GenreIcon = My.Resources.comedy_purple,
                .StartFilmingDate = New DateTime(2011, 1, 2),
                .ReleaseDate = New DateTime(2011, 9, 23),
                .Description = "The Intouchables  is a French film directed by Olivier Nakache and Éric Toledano. The feel-good dramatic comedy has become a cultural phenomenon in France. Starring: François Cluzet, Omar Sy."
            })
            movies.Add(New CinemaMovieInfo With {
                .Title = "Harry Potter and the Deathly Hallows",
                .StartTime = DateTime.Today.AddHours(24),
                .EndTime = DateTime.Today.AddHours(26),
                .Genre = "fantasy",
                .GenreIcon = My.Resources.fantasy_green,
                .StartFilmingDate = New DateTime(2010, 6, 12),
                .ReleaseDate = New DateTime(2010, 11, 19),
                .Description = "Harry Potter and the Deathly Hallows – Part 1 is a 2010 fantasy film directed by David Yates. Starring: Daniel Radcliffe, Rupert Grint, Emma Watson Principal photography began on 19 February 2009 and was completed on 12 June 2010. Part 1 was released in 2D cinemas and IMAX formats worldwide on 19 November 2010."
            })
            Return movies
        End Function
    End Module
End Namespace