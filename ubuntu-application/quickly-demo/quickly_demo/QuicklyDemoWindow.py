# -*- Mode: Python; coding: utf-8; indent-tabs-mode: nil; tab-width: 4 -*-
### BEGIN LICENSE
# This file is in the public domain
### END LICENSE

from locale import gettext as _

from gi.repository import Gtk # pylint: disable=E0611
import logging
logger = logging.getLogger('quickly_demo')

from quickly_demo_lib import Window
from quickly_demo.AboutQuicklyDemoDialog import AboutQuicklyDemoDialog
from quickly_demo.PreferencesQuicklyDemoDialog import PreferencesQuicklyDemoDialog

# See quickly_demo_lib.Window.py for more details about how this class works
class QuicklyDemoWindow(Window):
    __gtype_name__ = "QuicklyDemoWindow"
    
    def finish_initializing(self, builder): # pylint: disable=E1002
        """Set up the main window"""
        super(QuicklyDemoWindow, self).finish_initializing(builder)

        self.AboutDialog = AboutQuicklyDemoDialog
        self.PreferencesDialog = PreferencesQuicklyDemoDialog

        # Code for other initialization actions should be added here.

