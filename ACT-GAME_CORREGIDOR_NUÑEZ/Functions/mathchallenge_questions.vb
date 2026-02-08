Public Class question
    Public Shared questions As New List(Of String) From {
        "What is 12 × 4?",
        "If you divide 36 by 6, what do you get?",
        "What is 3/4 of 20?",
        "Which number is the smallest?",
        "What is the perimeter of a rectangle with length 8 and width 5?",
        "What comes next? 5, 10, 20, 40, ___",
        "If one pencil costs 7 pesos, how much do 5 pencils cost?",
        "Which fraction is greater?",
        "A bag has 24 marbles. If they are shared equally among 6 kids, how many does each get?",
        "What is the area of a square with side length 9?"
    }

    Public Shared answers As New List(Of String) From {
        "48",
        "6",
        "15",
        "12",
        "26",
        "80",
        "35",
        "3/4",
        "4",
        "81"
    }

    Public Shared choices As New List(Of List(Of String)) From {
        New List(Of String) From {"36", "40", "48", "52"},
        New List(Of String) From {"4", "5", "6", "7"},
        New List(Of String) From {"10", "12", "15", "18"},
        New List(Of String) From {"12", "18", "25", "30"},
        New List(Of String) From {"18", "22", "26", "30"},
        New List(Of String) From {"60", "70", "80", "100"},
        New List(Of String) From {"28", "30", "35", "40"},
        New List(Of String) From {"1/2", "2/3", "3/4", "4/5"},
        New List(Of String) From {"3", "4", "5", "6"},
        New List(Of String) From {"72", "81", "90", "99"}
    }

End Class
