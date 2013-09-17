################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/AnimationBaseForm.cpp \
../src/AnimationPropertyInfo.cpp \
../src/AppResourceId.cpp \
../src/CoverFlowPanel.cpp \
../src/DeletePopupPanel.cpp \
../src/MyHondana.cpp \
../src/MyHondanaDeleteForm.cpp \
../src/MyHondanaDetailForm.cpp \
../src/MyHondanaEntry.cpp \
../src/MyHondanaFormFactory.cpp \
../src/MyHondanaFrame.cpp \
../src/MyHondanaMainForm.cpp \
../src/MyHondanaMarketForm.cpp \
../src/MyHondanaPanelFactory.cpp \
../src/SceneRegister.cpp \
../src/SortPopupPanel.cpp 

OBJS += \
./src/AnimationBaseForm.o \
./src/AnimationPropertyInfo.o \
./src/AppResourceId.o \
./src/CoverFlowPanel.o \
./src/DeletePopupPanel.o \
./src/MyHondana.o \
./src/MyHondanaDeleteForm.o \
./src/MyHondanaDetailForm.o \
./src/MyHondanaEntry.o \
./src/MyHondanaFormFactory.o \
./src/MyHondanaFrame.o \
./src/MyHondanaMainForm.o \
./src/MyHondanaMarketForm.o \
./src/MyHondanaPanelFactory.o \
./src/SceneRegister.o \
./src/SortPopupPanel.o 

CPP_DEPS += \
./src/AnimationBaseForm.d \
./src/AnimationPropertyInfo.d \
./src/AppResourceId.d \
./src/CoverFlowPanel.d \
./src/DeletePopupPanel.d \
./src/MyHondana.d \
./src/MyHondanaDeleteForm.d \
./src/MyHondanaDetailForm.d \
./src/MyHondanaEntry.d \
./src/MyHondanaFormFactory.d \
./src/MyHondanaFrame.d \
./src/MyHondanaMainForm.d \
./src/MyHondanaMarketForm.d \
./src/MyHondanaPanelFactory.d \
./src/SceneRegister.d \
./src/SortPopupPanel.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	clang++.exe -I"pch" -I"C:\tizen-sdk\workspace\MyHondana\inc" -O3 -g -Wall -c -fmessage-length=0 -target arm-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../arm-linux-gnueabi-gcc-4.5/" -ccc-gcc-name arm-linux-gnueabi-g++ -march=armv7-a -mfloat-abi=softfp -mfpu=vfpv3-d16 -mtune=cortex-a8 -Wno-gnu -fPIE --sysroot="C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/libxml2" -I"C:\tizen-sdk\library" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/osp" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


