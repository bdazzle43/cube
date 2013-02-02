package com.dawndiy.action;

import java.text.SimpleDateFormat;
import java.util.Date;

import com.opensymphony.xwork2.ActionContext;
import com.opensymphony.xwork2.ActionSupport;

public class LoginAction extends ActionSupport {

	private String username;

	// 用于在页面上显示
	public String getUsername() {
		return username;
	}

	// 可接收来自 Action 的传参
	public void setUsername(String username) {
		this.username = username;
	}

	// Action 默认执行方法
	public String execute(){

		SimpleDateFormat tempDate = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		String time = tempDate.format(new Date());
		
		ActionContext.getContext().getSession().put("time", time);
//		ActionContext.getContext().getSession().put("user", getUsername());	//可直接在页面上获取
		
		return "in";
	}
	
	// 自定义的 Action 方法
	public String admin(){
		System.out.println("use admin()");
		username = "admin";
		return "in";
	}
	
	// 通过 GET/POST 方式获取请求参数
	public String getParameters(){
		return "in";
	}
	
	
}
