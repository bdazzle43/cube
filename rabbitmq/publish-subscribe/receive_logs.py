#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Publish/Subscribe
接收端
'''

import pika

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

channel.exchange_declare(exchange='logs',
                         type='fanout')

# 创建随机队列名
# exclusive=True 当与消费者断开连接的时候，队列应当被删除。
result = channel.queue_declare(exclusive=True)
queue_name = result.method.queue

# 绑定交换器和队列
channel.queue_bind(exchange='logs',
                   queue=queue_name)

print ' [*] Waiting for logs. To exit press CTRL+C'

def callback(ch, method, properties, body):
    print ' [x] %r' % (body,)

channel.basic_consume(callback,
                      queue=queue_name,
                      no_ack=True)

channel.start_consuming()
