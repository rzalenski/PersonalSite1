Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Function Index() As ActionResult
        Return View()
    End Function
    Function About() As ActionResult
        ViewData("Message") = "Your About Me page."
        Return View()
    End Function
    Function Contact() As ActionResult
        ViewData("Message") = "Your Contact page."
        Return View()
    End Function
    Function Skills() As ActionResult
        ViewData("Message") = "Your Skills page."
        Return View()
    End Function
    Function CareerHistory() As ActionResult
        ViewData("Message") = "Your Career History page."
        Return View()
    End Function
    Function Portfolio() As ActionResult
        ViewData("Message") = "Your Portfolio page."
        Return View()
    End Function
End Class
