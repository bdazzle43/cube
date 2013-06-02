#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Publish/Subscribe
发送端
'''

import pika
import sys

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

# 创建一个交换器，类型为 fanout
channel.exchange_declare(exchange='logs',   # 交换器名
                         type='fanout')     # 广播给所有队列 

message = ' '.join(sys.argv[1:]) or 'info: Hello World!'

# 指定发送消息到一个具体的（logs）交换器
channel.basic_publish(exchange='logs',
                      routing_key='',
                      body=message)

print ' [x] Sent %r' % (message,)

connection.close()
