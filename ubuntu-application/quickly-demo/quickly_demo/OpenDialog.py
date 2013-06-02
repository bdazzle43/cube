# -*- Mode: Python; coding: utf-8; indent-tabs-mode: nil; tab-width: 4 -*-
### BEGIN LICENSE
# This file is in the public domain
### END LICENSE

import os
from quickly.widgets.dictionary_grid import DictionaryGrid
from gi.repository import GLib # pylint: disable=E0611
from gi.repository import Gtk # pylint: disable=E0611

from quickly_demo_lib.helpers import get_builder

import gettext
from gettext import gettext as _
gettext.textdomain('quickly-demo')

class OpenDialog(Gtk.Dialog):
    __gtype_name__ = "OpenDialog"

    def __new__(cls):
        """Special static method that's automatically called by Python when 
        constructing a new instance of this class.
        
        Returns a fully instantiated OpenDialog object.
        """
        builder = get_builder('OpenDialog')
        new_object = builder.get_object('open_dialog')
        new_object.finish_initializing(builder)
        return new_object

    def finish_initializing(self, builder):
        """Called when we're finished initializing.

        finish_initalizing should be called after parsing the ui definition
        and creating a OpenDialog object with it in order to
        finish initializing the start of the new OpenDialog
        instance.
        """
        # Get a reference to the builder and set up the signals.
        self.builder = builder
        self.ui = builder.get_ui(self)
        
        #get the jotty document names
        data_dir = GLib.get_user_data_dir()
        jotty_dir = os.path.join(data_dir, "jotty")
        filenames = os.listdir(jotty_dir)
        
        #put them into a grid
        dicts = [{'Name': x, 'File': os.path.join(jotty_dir, x)} for x in filenames]
        self.grid = DictionaryGrid(dictionaries=dicts, keys=['Name'])
        
        #add grid to dialog
        self.grid.show()
        self.ui.box1.pack_end(self.grid, True, True, 0)

    def on_btn_ok_clicked(self, widget, data=None):
        """The user has elected to save the changes.

        Called before the dialog returns Gtk.ResponseType.OK from run().
        """
        pass

    def on_btn_cancel_clicked(self, widget, data=None):
        """The user has elected cancel changes.

        Called before the dialog returns Gtk.ResponseType.CANCEL for run()
        """
        pass

    @property
    def selected_file(self):
        rows = self.grid.selected_rows
        if len(rows) < 1:
            return None
        else:
            return rows[0]['Name']

if __name__ == "__main__":
    dialog = OpenDialog()
    dialog.show()
    Gtk.main()
