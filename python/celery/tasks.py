# -*- coding: utf-8 -*-

# 运行 celery worker 服务
# $ celery -A tasks worker --loglevel=info
# 调用 task
# >>> from tasks import add
# >>> add.delay(4, 4)
# 查看结果
# >>> result = add.delay(4, 4)
# >>> result.ready()
# True
# >>> result.get(timeout=1)
# 8

from celery import Celery

celery = Celery('tasks', backend='amqp', broker='amqp://guest@localhost//')

@celery.task
def add(x, y):
    return x + y
