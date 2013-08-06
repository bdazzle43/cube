import web

url = ("/.*", "hello")
app = web.application(url, globals())

class hello:
    def GET(self):
        return 'Hello, world!'

if __name__ == "__main__":
    app.run()
