/*
 * 对象的序列化测试
 * ================
 *
 * 客户端，使用 Socket 将实例化后的对象发送给服务端。
 */

import java.io.ObjectOutputStream;
import java.net.Socket;
import java.io.Serializable; 

public class SocketClient {

    public static void main(String[] args) {
        Socket socket = null;
        try {
            socket = new Socket("127.0.0.1", 3737);
            new ObjectOutputStream(socket.getOutputStream()).writeObject(new Person("Tom", 23));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

// class Person { // 如果不序列化，将会出现 java.io.NotSerializableException 异常
class Person implements Serializable {
    private String name;
    private int age;

    public Person() {}

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }
    
    public void show() {
        System.out.println("Person:\n" +
                           "name=" + this.name +
                           "\tage=" + this.age);
    }
}
