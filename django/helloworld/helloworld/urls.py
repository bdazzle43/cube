from django.conf.urls import patterns, include, url

# Uncomment the next two lines to enable the admin:
# from django.contrib import admin
# admin.autodiscover()

urlpatterns = patterns('',
    # Examples:
    # url(r'^$', 'helloworld.views.home', name='home'),
    # url(r'^helloworld/', include('helloworld.foo.urls')),

    # Uncomment the admin/doc line below to enable admin documentation:
    # url(r'^admin/doc/', include('django.contrib.admindocs.urls')),

    # Uncomment the next line to enable the admin:
    # url(r'^admin/', include(admin.site.urls)),
	url(r'^hello/$', 'helloworld.views.hello'),
	url(r'^time/$', 'helloworld.views.current_datetime'),
	url(r'^time2/$', 'helloworld.views.current_datetime_with_template'),
	url(r'^time3/$', 'helloworld.views.current_datetime_with_tempfile'),
	url(r'^time/plus/(\d{1,2})/$', 'helloworld.views.hours_ahead'),	
	url(r'^time2/plus/(\d{1,2})/$', 'helloworld.views.hours_ahead_with_tempfile'),	
)
