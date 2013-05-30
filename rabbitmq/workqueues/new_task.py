#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Work Queues
发送端
'''

import sys
import pika

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

# 声明队列,测试位置是否可达
# durable 消息持久化
channel.queue_declare(queue='task_queue', durable=True)

message = ' '.join(sys.argv[1:]) or "Hello World!"
channel.basic_publish(exchange='',
                      routing_key='task_queue',
                      body=message,
                      properties=pika.BasicProperties(
                         delivery_mode = 2, # 使消息持久化
                      ))
print " [x] Sent %r" % (message,)
connection.close()
