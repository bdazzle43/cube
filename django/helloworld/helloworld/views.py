from django.http import HttpResponse
import datetime

def hello(request):
	return HttpResponse("Hello world!")

def current_datetime(request):
	now = datetime.datetime.now()
	html = "<html><body><h2>It is now %s</h2></body></html>" % now
	return HttpResponse(html)
