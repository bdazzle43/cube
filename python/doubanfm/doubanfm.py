#!/usr/bin/env python
# -*- coding:utf-8 -*-

'''
Created on 2013-1-28

@author: dawndiy
'''

class Song:
    def __init__(self):
        self.album = ''             # 专辑
        self.picture = ''           # 封面
        self.ssid = ''              # SSID
        self.artist = ''            # 演唱家
        self.url = ''               # mp3 url
        self.company = ''           # 公司
        self.title = ''             # 标题
        self.rating_avg = 0
        self.public_time = ''
        self.subtype = ''
        self.length = 0
        self.sid = ''
        self.aid = ''
        self.kbps = ''
        self.albumtitle = ''
        self.like = False
            
    def setSongInfo(self, song):
        self.album = song['album']
        self.picture = song['picture']
        self.ssid = song['ssid']
        self.artist = song['artist']
        self.url = song['url']
        self.company = song['company']
        self.title = song['title']
        self.rating_avg = song['rating_avg']
        self.public_time = song['public_time']
        self.subtype = song['subtype']
        self.length = song['length']
        self.sid = song['sid']
        self.aid = song['aid']
        self.kbps = song['kbps']
        self.albumtitle = song['albumtitle']
        self.like = song['like']
        
    def showInfo(self):
        print('album:' + self.album)
        print('picture:' + self.picture)
        print('ssid:' + self.ssid)
        print('artist:' + self.artist)
        print('url:' + self.url)
        print('company:' + self.company)
        print('title:' + self.title)
        print('rating_avg:' + str(self.rating_avg))
        print('public_time:' + self.public_time)
        print('subtype:' + self.subtype)
        print('length:' + str(self.length))
        print('sid:' + self.sid)
        print('aid:' + self.aid)
        print('kbps:' + self.kbps)
        print('albumtitle:' + self.albumtitle)
        print('like:' + str(self.like))
        
        
        


import json, urllib2

ch_url = 'http://douban.fm/j/mine/playlist?type=p&sid=&channel=0'

getJson = json.load(urllib2.urlopen(ch_url))

print getJson

songlist = getJson['song']
print songlist


song = Song()
for s in songlist:
    song.setSongInfo(s)
    song.showInfo()
    break
    
    



