#!/usr/bin/python
# -*- Mode: Python; coding: utf-8; indent-tabs-mode: nil; tab-width: 4 -*-
### BEGIN LICENSE
# This file is in the public domain
### END LICENSE

import sys
import os.path
import unittest
sys.path.insert(0, os.path.realpath(os.path.join(os.path.dirname(__file__), "..")))

from quickly_demo import AboutQuicklyDemoDialog

class TestExample(unittest.TestCase):
    def setUp(self):
        self.AboutQuicklyDemoDialog_members = [
        'AboutDialog', 'AboutQuicklyDemoDialog', 'gettext', 'logger', 'logging']

    def test_AboutQuicklyDemoDialog_members(self):
        all_members = dir(AboutQuicklyDemoDialog)
        public_members = [x for x in all_members if not x.startswith('_')]
        public_members.sort()
        self.assertEqual(self.AboutQuicklyDemoDialog_members, public_members)

if __name__ == '__main__':    
    unittest.main()
