#!/usr/bin/env python3
# -*- coding: utf-8 -*-

import json

songJson = {"album":"\/subject\/10456999\/","picture":"http:\/\/img3.douban.com\/mpic\/s8945271.jpg","ssid":"77cd","artist":"保志総一朗","url":"http:\/\/mr3.douban.com\/201301282153\/a9be6ded9a4f55ecf695d7aacae3c765\/view\/song\/small\/p1886008.mp3","company":"キングレコード","title":"理想郷へのカデンツァ","rating_avg":3.91026,"length":277,"subtype":"","public_time":"2012","sid":"1886008","aid":"10456999","kbps":"64","albumtitle":"ONE SONGS","like":False}

print('title:', songJson['title'])
print('artist:', songJson['artist'])
print('public time:', songJson['public_time'])
print('kbps:', songJson['kbps'])

