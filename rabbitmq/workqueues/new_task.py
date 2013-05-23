#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Work Queues

'''

import sys
import pika

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

# 声明队列,测试位置是否可达
channel.queue_declare(queue='hello')

message = ' '.join(sys.argv[1:]) or "Hello World!"
channel.basic_publish(exchange='',
                     routing_key='hello',
                     body=message)
print " [x] Sent %r" % (message,)
