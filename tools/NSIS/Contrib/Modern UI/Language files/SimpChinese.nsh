;NSIS Modern User Interface - Language File
;Compatible with Modern UI 1.68

;Language: 'Chinese (Simplified)' (2052)
;Translator: Kii Ali <kiiali@cpatch.org>
;Revision date: 2004-12-15
;--------------------------------

!insertmacro MUI_LANGUAGEFILE_BEGIN "SimpChinese"

  !define MUI_LANGNAME "Chinese (Simplified)" ;(�����Ա���ķ�ʽ��д����������) Use only ASCII characters (if this is not possible, use the English name)
  
  !define MUI_TEXT_WELCOME_INFO_TITLE "��ӭʹ�� $(^NameDA) ��װ��"
  !define MUI_TEXT_WELCOME_INFO_TEXT "����򵼽�ָ������� $(^NameDA) �İ�װ���̡�\r\n\r\n�ڿ�ʼ��װ֮ǰ�������ȹر���������Ӧ�ó����⽫������װ���򡱸���ָ����ϵͳ�ļ���������Ҫ����������ļ������\r\n\r\n$_CLICK"
  
  !define MUI_TEXT_LICENSE_TITLE "���֤Э��"
  !define MUI_TEXT_LICENSE_SUBTITLE "�ڰ�װ $(^NameDA) ֮ǰ���������Ȩ���"
  !define MUI_INNERTEXT_LICENSE_TOP "����Э������ಿ�֣��밴 [PgDn] ���¾�ҳ�档"
  !define MUI_INNERTEXT_LICENSE_BOTTOM "��������Э���е�������� [��ͬ��(I)] ������װ�������ѡ�� [ȡ��(C)] ����װ���򽫻�رա�����Ҫ����Э����ܰ�װ $(^NameDA) ��"
  !define MUI_INNERTEXT_LICENSE_BOTTOM_CHECKBOX "��������Э���е���������·��Ĺ�ѡ�򡣱���Ҫ����Э����ܰ�װ $(^NameDA)��$_CLICK"
  !define MUI_INNERTEXT_LICENSE_BOTTOM_RADIOBUTTONS "��������Э���е����ѡ���·���һ��ѡ�����Ҫ����Э����ܰ�װ $(^NameDA)��$_CLICK"
  
  !define MUI_TEXT_COMPONENTS_TITLE "ѡ�����"
  !define MUI_TEXT_COMPONENTS_SUBTITLE "ѡ������Ҫ��װ $(^NameDA) ����Щ���ܡ�"
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_TITLE "����"
  !ifndef NSIS_CONFIG_COMPONENTPAGE_ALTERNATIVE
    !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_INFO "�ƶ�������ָ�뵽���֮�ϣ���ɼ�������������"
  !else
    !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_INFO "ѡ��һ���������ɼ�������������"
  !endif
  
  !define MUI_TEXT_DIRECTORY_TITLE "ѡ����װλ��" 
  !define MUI_TEXT_DIRECTORY_SUBTITLE "ѡ�� $(^NameDA) Ҫ��װ���ļ��С�"

  !define MUI_TEXT_INSTALLING_TITLE "���ڰ�װ"
  !define MUI_TEXT_INSTALLING_SUBTITLE "$(^NameDA) ���ڰ�װ����Ⱥ�"
  
  !define MUI_TEXT_FINISH_TITLE "��װ���"
  !define MUI_TEXT_FINISH_SUBTITLE "��װ�����ѳɹ���������ɡ�"
  
  !define MUI_TEXT_ABORT_TITLE "��װ����ֹ"
  !define MUI_TEXT_ABORT_SUBTITLE "��װ����δ�ɹ���������ɡ�"
  
  !define MUI_BUTTONTEXT_FINISH "���(&F)"
  !define MUI_TEXT_FINISH_INFO_TITLE "������� $(^NameDA) ��װ��"
  !define MUI_TEXT_FINISH_INFO_TEXT "$(^NameDA) �Ѱ�װ�����ϵͳ��\r\n���� [���(F)] �رմ��򵼡�"
  !define MUI_TEXT_FINISH_INFO_REBOOT "���ϵͳ��Ҫ�����������Ա���� $(^NameDA) �İ�װ������Ҫ����������"
  !define MUI_TEXT_FINISH_REBOOTNOW "�ǣ�������������(&Y)"
  !define MUI_TEXT_FINISH_REBOOTLATER "�����Ժ���������������(&N)"
  !define MUI_TEXT_FINISH_RUN "���� $(^NameDA)(&R)"
  !define MUI_TEXT_FINISH_SHOWREADME "��ʾ�������ļ���(&M)"
  
  !define MUI_TEXT_STARTMENU_TITLE "ѡ�񡰿�ʼ�˵����ļ���"
  !define MUI_TEXT_STARTMENU_SUBTITLE "ѡ�񡰿�ʼ�˵����ļ��У����ڳ���Ŀ�ݷ�ʽ��"
  !define MUI_INNERTEXT_STARTMENU_TOP "ѡ�񡰿�ʼ�˵����ļ��У��Ա㴴������Ŀ�ݷ�ʽ����Ҳ�����������ƣ��������ļ��С�"
  !define MUI_INNERTEXT_STARTMENU_CHECKBOX "��Ҫ������ݷ�ʽ(&N)"
  
  !define MUI_TEXT_ABORTWARNING "��ȷʵҪ�˳� $(^Name) ��װ����"
  

  !define MUI_UNTEXT_WELCOME_INFO_TITLE "��ӭʹ�� $(^NameDA) �����װ��"
  !define MUI_UNTEXT_WELCOME_INFO_TEXT "����򵼽�ȫ��ָ���� $(^NameDA) �Ľ����װ���̡�\r\n\r\n�ڿ�ʼ�����װ֮ǰ��ȷ�� $(^NameDA) ��δ���е��С�\r\n\r\n$_CLICK"
 
  !define MUI_UNTEXT_CONFIRM_TITLE "�����װ $(^NameDA)"
  !define MUI_UNTEXT_CONFIRM_SUBTITLE "����ļ���������װ $(^NameDA) ��"
  
  !define MUI_UNTEXT_LICENSE_TITLE "���֤Э��"
  !define MUI_UNTEXT_LICENSE_SUBTITLE "�ڽ����װ $(^NameDA) ֮ǰ���������Ȩ���"
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM "��������Э���е�������� [��ͬ��(I)] ���������װ�������ѡ�� [ȡ��(C)] ����װ���򽫻�رա�����Ҫ����Э����ܽ����װ $(^NameDA) ��"
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM_CHECKBOX "��������Э���е���������·��Ĺ�ѡ�򡣱���Ҫ����Э����ܽ����װ $(^NameDA)��$_CLICK"
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM_RADIOBUTTONS "��������Э���е����ѡ���·���һ��ѡ�����Ҫ����Э����ܽ����װ $(^NameDA)��$_CLICK"
  
  !define MUI_UNTEXT_COMPONENTS_TITLE "ѡ�����"
  !define MUI_UNTEXT_COMPONENTS_SUBTITLE "ѡ�� $(^NameDA) ��������Ҫ�����װ�Ĺ��ܡ�"
  
  !define MUI_UNTEXT_DIRECTORY_TITLE "ѡ�������װλ��" 
  !define MUI_UNTEXT_DIRECTORY_SUBTITLE "ѡ�� $(^NameDA) Ҫ�����װ���ļ��С�"

  !define MUI_UNTEXT_UNINSTALLING_TITLE "���ڽ����װ"
  !define MUI_UNTEXT_UNINSTALLING_SUBTITLE "$(^NameDA) ���ڽ����װ����Ⱥ�"
    
  !define MUI_UNTEXT_FINISH_TITLE "�����װ�����"
  !define MUI_UNTEXT_FINISH_SUBTITLE "�����װ�����ѳɹ���������ɡ�"
  
  !define MUI_UNTEXT_ABORT_TITLE "�����װ����ֹ"
  !define MUI_UNTEXT_ABORT_SUBTITLE "�����װ����δ�ɹ���������ɡ�"
  
  !define MUI_UNTEXT_FINISH_INFO_TITLE "������� $(^NameDA) �����װ��"
  !define MUI_UNTEXT_FINISH_INFO_TEXT "$(^NameDA) �Ѵ���ļ���������װ��\r\n\r\n���� [���] �ر�����򵼡�"
  !define MUI_UNTEXT_FINISH_INFO_REBOOT "�������Ҫ�����������Ա���� $(^NameDA) �Ľ����װ��������Ҫ����������"

  !define MUI_UNTEXT_ABORTWARNING "��ȷʵҪ�˳� $(^Name) �����װ��"  
  
!insertmacro MUI_LANGUAGEFILE_END
