# TextureScale

概要

Oculus SDK 0.4.4において外部からTextuteScaleを変更できる機能を追加する。

使い方

* OculusUnityIntegration.unitypackageを取り込む
* TextureScale.csを追加する
* dataフォルダをAssetsのトップにコピーする
* data/ConfigTextureScale.txtを適当に編集する
*OVRManager.csの325行目に以下の行を加える

'
        TextureScale.InitTextureScale();
'

'
==== OVRManager.cs:313～327行目のイメージ ===

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

* UnityEditor上で実行し動作確認をする

* アプリをビルドする
* dataフォルダをアプリと同じところにコピーする(ファイルではなく、フォルダごとコピー)

'
====設定後のイメージ(Windows)====
    OculusApp.exe
    OculusApp_DirectToRift.exe
    OculusApp_Data\
    data\

====設定後のイメージ(Mac OS X)====
    OculusApp.app
    data/
'

* アプリ実行前にdata/ConfigTextureScale.txtファイルを確認
* アプリを実行
