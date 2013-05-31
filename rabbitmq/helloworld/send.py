#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Hello World
发送端
'''

import pika

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

# 声明队列,测试位置是否可达，设置队列名
channel.queue_declare(queue='hello')

# 发送消息
channel.basic_publish(exchange='',          # 交换器
                      routing_key='hello',  # 路由键
                      body='Hello World!')  # 消息

print " [x] Send 'Hello World!'"

# 关闭链接
connection.close()

