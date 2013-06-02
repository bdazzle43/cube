/*
 * 对象的序列化测试
 * ================
 *
 * 服务端，使用 Socket 接收一个从客户端传输来的对象。
 */

import java.net.ServerSocket;
import java.net.Socket;
import java.io.ObjectInputStream;

public class SocketServer {
    
    public static void main(String[] args) {
        ServerSocket server = null;
        Socket socket = null;

        try {
            server = new ServerSocket(3737);
            socket = server.accept();
        } catch (Exception e) {
            e.printStackTrace();
        }

        try {
            Person p = (Person)(new ObjectInputStream(socket.getInputStream()).readObject());
            p.show();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
