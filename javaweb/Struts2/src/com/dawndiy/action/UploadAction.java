package com.dawndiy.action;

import java.io.File;
import java.io.IOException;

import org.apache.commons.io.FileUtils;
import org.apache.struts2.ServletActionContext;

import com.opensymphony.xwork2.ActionContext;
import com.opensymphony.xwork2.ActionSupport;

public class UploadAction extends ActionSupport {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	private File file;
	private String fileFileName;

	public File getFile() {
		return file;
	}

	public void setFile(File file) {
		this.file = file;
	}

	public String getFileFileName() {
		return fileFileName;
	}

	public void setFileFileName(String fileFileName) {
		this.fileFileName = fileFileName;
	}

	// 上传文件 Action
	public String execute() throws IOException {

		String realPath = ServletActionContext.getServletContext().getRealPath(
				"/upload");
		System.out.println(realPath);
		File saveFile = new File(new File(realPath), fileFileName);
		if (!saveFile.exists())
			saveFile.getParentFile().mkdir();
		FileUtils.copyFile(file, saveFile);
		ActionContext.getContext().put("msg", "上传成功");

		return "msg";
	}

}
