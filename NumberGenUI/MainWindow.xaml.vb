imports System

class MainWindow

    private sub TextBox_TextChanged(sender as object, e as TextChangedEventArgs)

    end sub

    private sub Button_Click(sender as object, e as RoutedEventArgs)

        dim max as integer
        dim min as integer
        dim rand

        if Text1.Text then
            min = integer.Parse(Text1.Text)
        end if

        if Text2.Text then
            max = integer.Parse(Text2.Text)
        end if

        rand = new Random()
        Output.Text = rand.Next(min, max)

    end sub

end class
