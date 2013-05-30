#!/usr/bin/env python
#-*- coding: utf-8 -*-

'''
Rabbitmq Tutorial: Work Queues
接收端
'''

import pika
import time

# 建立链接
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost'))
channel = connection.channel()

# 声明队列,测试位置是否可达
channel.queue_declare(queue='task_queue', durable=True)

print ' [*] Waiting for messages. To exit press CTRL+C'

# 回调函数
def callback(ch, method, properties, body):
    print " [x] Received %r" % (body,)
    time.sleep( body.count('.') )
    print " [x] Done"
    ch.basic_ack(delivery_tag = method.delivery_tag)
    
# 告诉 RabbitMQ 在同一时刻不要发送超过1条消息给一个工作者，
# 直到它已经处理了上一条消息并作出了响应。
channel.basic_qos(prefetch_count=1)
# 告诉回调函数从 hello 队列里面接收消息
channel.basic_consume(callback,
                      queue='task_queue')

channel.start_consuming()
