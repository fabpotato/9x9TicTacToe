' The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkID=391641

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    'integer counter = 0
    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.
    ''' This parameter is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        ' TODO: Prepare the page for display here.

        ' TODO: If your application contains multiple pages, ensure that you are
        ' handling the hardware Back button by registering for the
        ' Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
        ' If you are using the NavigationHelper provided by some templates,
        ' this event is handled for you.
    End Sub


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' If (counter/2 == 0){
        Ax.Visibility = Windows.UI.Xaml.Visibility.Visible
        '  }
        ' Else{
        '  Ao.Visibility = Windows.UI.Xaml.Visibility.Visible
        '  }
        ' counter++
    End Sub
End Class
