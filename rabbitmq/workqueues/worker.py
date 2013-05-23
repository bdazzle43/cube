#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Hello World!
接收端
'''

import pika
import time

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

# 声明队列,测试位置是否可达
channel.queue_declare(queue='hello')

print ' [*] Waiting for messages. To exit press CTRL+C'

# 回调函数
def callback(ch, method, properties, body):
    print " [x] Received %r" % (body,)
    time.sleep( body.count('.') )
    print " [x] Done"
    ch.basic_ack(delivery_tag = method.delivery_tag)
    

# 告诉回调函数从 hello 队列里面接收消息
channel.basic_consume(callback,
                      queue='hello')

channel.start_consuming()
