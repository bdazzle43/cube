from django.template.loader import get_template
from django.template import Template, Context
from django.http import HttpResponse, Http404
import datetime

def hello(request):
	return HttpResponse("Hello world!")

def current_datetime(request):
	now = datetime.datetime.now()
	html = "<html><body><h2>It is now %s</h2></body></html>" % now
	return HttpResponse(html)

def hours_ahead(request, offset):
	try:
		offset = int(offset)
	except ValueError:
		raise Http404()
	dt = datetime.datetime.now() + datetime.timedelta(hours=offset)
	html = "<html><body>In %s hour(s), it will be %s.</body></html>" % (offset, dt)
	return HttpResponse(html)

def current_datetime_with_template(request):
	now = datetime.datetime.now()
	t = Template("<html><body>It is now {{ current_date }}</body></html>")
	c = Context({'current_date': now})
	html = t.render(c)
	return HttpResponse(html)

def current_datetime_with_tempfile(request):
	now = datetime.datetime.now()
	t = get_template('time.html')
	html = t.render(Context({'current_date': now}))
	return HttpResponse(html)
