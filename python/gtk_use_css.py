#!/usr/bin/env python

from gi.repository import Gtk, Gdk

win = Gtk.Window()
win.set_name("MyWindow")

button = Gtk.Button("Click Me")
win.add(button)

win.connect("delete-event", Gtk.main_quit)

# use css
style_provider = Gtk.CssProvider()

css = """
#MyWindow {
	background-color: #F00;
}
#MyWindow GtkButton {
	background: #000;
	border-radius: 10px;
	border-color: #000;
	box-shadow: 0 0 5px #003 inset;
	margin: 10px;
}
"""
style_provider.load_from_data(css)

Gtk.StyleContext.add_provider_for_screen(
		Gdk.Screen.get_default(),
		style_provider,
		Gtk.STYLE_PROVIDER_PRIORITY_APPLICATION
)


win.show_all()
Gtk.main()
