#!/usr/bin/env python

from gi.repository import Gtk


#glade = gtk.glade.XML("preferences.glade")
#win = glade.get_widget("window")
#win.show_all()
#dialog = glade.get_widget("about_dialog")
#dialog.show_all()

class Test:
	def __init__(self):
		'''
		self.glade = gtk.glade.XML("preferencs.glade")
		self.win = self.glade.get_widget("window")
		self.win.show_all()
		'''
		builder = Gtk.Builder()
		builder.add_from_file("preferences.glade")
		self.win = builder.get_object("aboutdialog")
		self.win.show_all()

if __name__ == "__main__":
	t = Test()
	Gtk.main()

