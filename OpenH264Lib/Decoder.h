// OpenH264Lib.h

#pragma once

using namespace System;
using namespace System::Runtime::InteropServices;
#include <array>

namespace OpenH264Lib
{

	public ref class Decoder
	{
	private:
		ISVCDecoder* decoder;

	private:
		typedef int(__stdcall* WelsCreateDecoderFunc)(ISVCDecoder** ppDecoder);
		WelsCreateDecoderFunc CreateDecoderFunc;
		typedef void(__stdcall* WelsDestroyDecoderFunc)(ISVCDecoder* ppDecoder);
		WelsDestroyDecoderFunc DestroyDecoderFunc;

	private:
		~Decoder(); // デストラクタ
		!Decoder(); // ファイナライザ
	public:
		Decoder(String^ dllName);

	private:
		int Setup();

	public:
		///<summary>Decode h264 frame data to Bitmap.</summary>
		///<returns>Bitmap. Might be null if frame data is incomplete.</returns>
		System::Drawing::Bitmap^ Decode(array<Byte>^ frame, int length);
		System::Drawing::Bitmap^ Decode(unsigned char* frame, int length);
		///<summary>Decode h.264 frame data to an RGB buffer.</summary>
		///<returns>Byte array. Might be null if frame data is incomplete.</returns>
		array<Byte>^ DecodeToRGB(array<Byte>^ frame, [Out] int% width, [Out] int% height);
		///<summary>Decode h.264 frame data to an RGB buffer.</summary>
		///<returns>Byte array. Might be null if frame data is incomplete.</returns>
		array<Byte>^ DecodeToRGB(array<Byte>^ frame, int length, [Out] int% width, [Out] int% height);
		///<summary>Decode h.264 frame data to YUV planes.</summary>
		///<returns>Array of byte arrays. Might be null if frame data is incomplete.</returns>
		array<array<Byte>^>^ DecodeToYUV(array<Byte>^ frame, int length, [Out] int% width, [Out] int% height, [Out] int% stride);
		///<summary>Converts YUV planes to an RGB byte array.</summary>
		///<returns>Byte array.</returns>
		static array<Byte>^ YUV420PtoRGB(array<array<Byte>^>^ planes, int width, int height, int stride);

	private:
		std::array<byte*, 3>* DecodeToYUVInternal(unsigned char* frame, int length, [Out] int% width, [Out] int% height, [Out] int% stride);
		///<summary>Decode h.264 frame data to an RGB buffer.</summary>
		///<returns>byte*. Might be null if frame data is incomplete.</returns>
		byte* DecodeToRGBInternal(unsigned char* frame, int length, [Out] int% width, [Out] int% height);
		static byte* YUV420PtoRGB(byte* yplane, byte* uplane, byte* vplane, int width, int height, int stride);
		static System::Drawing::Bitmap^ RGBtoBitmap(byte* rgb, int width, int height);
	};
}
