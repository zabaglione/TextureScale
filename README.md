# TextureScale

�T�v

Oculus SDK 0.4.4�ɂ����ĊO������TextuteScale��ύX�ł���@�\��ǉ�����B

�g����

* OculusUnityIntegration.unitypackage����荞��
* TextureScale.cs��ǉ�����
* data�t�H���_��Assets�̃g�b�v�ɃR�s�[����
* data/ConfigTextureScale.txt��K���ɕҏW����
*OVRManager.cs��325�s�ڂɈȉ��̍s��������

'
        TextureScale.InitTextureScale();
'

'
==== OVRManager.cs:313�`327�s�ڂ̃C���[�W ===

	private void Awake()
	{
		// Only allow one instance at runtime.
		if (instance != null)
		{
			enabled = false;
			DestroyImmediate(this);
			return;
		}

		instance = this;

        TextureScale.InitTextureScale();

#if !UNITY_ANDROID || UNITY_EDITOR
		if (!ovrIsInitialized)

===============================
'

* UnityEditor��Ŏ��s������m�F������

* �A�v�����r���h����
* data�t�H���_���A�v���Ɠ����Ƃ���ɃR�s�[����(�t�@�C���ł͂Ȃ��A�t�H���_���ƃR�s�[)

'
====�ݒ��̃C���[�W(Windows)====
    OculusApp.exe
    OculusApp_DirectToRift.exe
    OculusApp_Data\
    data\

====�ݒ��̃C���[�W(Mac OS X)====
    OculusApp.app
    data/
'

* �A�v�����s�O��data/ConfigTextureScale.txt�t�@�C�����m�F
* �A�v�������s
