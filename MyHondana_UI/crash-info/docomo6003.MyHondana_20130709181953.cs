S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG2
Build-Date: 2013.07.04 20:54:23

Crash Information
Process Name: MyHondana
PID: 17094
Date: 2013-07-09 18:19:53(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=17094 tid=17094
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 17094, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbeff54d0
r2   = 0x00000001, r3   = 0xbeff54d0
r4   = 0xad604cf0, r5   = 0xb41e4598
r6   = 0xbeff54d0, r7   = 0xad604cf0
r8   = 0xa00009cb, r9   = 0xbeff58a4
r10  = 0x00000001, fp   = 0xbeff5720
ip   = 0xb2ee3e48, sp   = 0xbeff52a0
lr   = 0xb3c1272b, pc   = 0xb3d2d6d4
cpsr = 0x08010030

Memory Information
MemTotal:  2063912 KB
MemFree:    517704 KB
Buffers:     73952 KB
Cached:    1038264 KB
VmPeak:     185704 KB
VmSize:     146896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       80180 KB
VmRSS:       80180 KB
VmData:      45184 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66124 KB
VmPTE:         166 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00092000 rw-p [heap]
00092000 01770000 rw-p [heap]
b05d3000 b05d7000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05e0000 b0ddf000 rwxp [stack:17096]
b0ddf000 b0f2d000 r-xp /usr/lib/r3p2/libMali.so
b0f39000 b0f61000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f65000 b0f83000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f95000 b0f9b000 r-xp /usr/lib/libUMP.so
b12dd000 b1329000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b1332000 b1337000 r-xp /usr/lib/libjson.so.0.0.1
b133f000 b1343000 r-xp /usr/lib/liblocation-pos-log.so
b134b000 b1356000 r-xp /usr/lib/libmdm-common.so.1.0.37
b135e000 b1370000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1378000 b137a000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b1382000 b1387000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b138f000 b139a000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b13a2000 b13a4000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b13ac000 b13b9000 r-xp /usr/lib/libdrm-client.so.0.0.90
b13c2000 b13ca000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13ec000 b1423000 r-xp /usr/lib/libpulse.so.0.16.2
b142b000 b148f000 r-xp /usr/lib/libasound.so.2.0.0
b1499000 b149c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b14a5000 b14a9000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b14b2000 b14cf000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b14d7000 b14dc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14e4000 b1511000 r-xp /usr/lib/libSLP-location.so.0.0.0
b151a000 b1557000 r-xp /usr/lib/libmdm.so.1.0.63
b155f000 b1563000 r-xp /usr/lib/libss-client.so.1.0.0
b156c000 b1575000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b157d000 b1581000 r-xp /usr/lib/libmmffile.so.0.0.0
b1589000 b1590000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1599000 b15b3000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b15bb000 b15d6000 r-xp /usr/lib/libmedia-service.so.1.0.0
b15de000 b15f3000 r-xp /usr/lib/libnetwork.so.0.0.0
b15fb000 b1609000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b1612000 b1619000 r-xp /usr/lib/libenchant.so.1.6.1
b1621000 b1624000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b162d000 b1636000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b163f000 b1643000 r-xp /usr/lib/libmmfsession.so.0.0.0
b164c000 b165b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1663000 b1668000 r-xp /usr/lib/libmemenv.so.1.1.0
b1670000 b16ae000 r-xp /usr/lib/libleveldb.so.1.1.0
b16b7000 b16e1000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b16ea000 b16ec000 r-xp /usr/lib/libsecfw.so
b16f4000 b16fd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1708000 b1717000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b171f000 b1737000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1739000 b1746000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b174f000 b1758000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b1760000 b17a2000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b17ab000 b1847000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b1853000 b1878000 r-xp /usr/lib/libxslt.so.1.1.16
b1881000 b1883000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b188b000 b1893000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b189b000 b18a6000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b18ae000 b18c5000 r-xp /usr/lib/libwifi-direct.so.0.0
b18cd000 b18d5000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b18dd000 b18e6000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b18ee000 b18f1000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b18f9000 b1920000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1928000 b193e000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1947000 b1951000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b1959000 b1962000 r-xp /usr/lib/libcapi-web-favorites.so
b196a000 b2bc2000 r-xp /usr/lib/libewebkit2.so.0.10.144.6
b2cb5000 b2d6a000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2d77000 b2d95000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2d9e000 b2db8000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2dc1000 b2e14000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2e1d000 b2e81000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2e94000 b2e9e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2ea6000 b2eda000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2ee5000 b2f2d000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f35000 b2fc5000 r-xp /usr/lib/libCOREGL.so.3.0
b2fcf000 b2fd2000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fda000 b2fe1000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fea000 b2ff9000 r-xp /usr/lib/libICE.so.6.3.0
b3003000 b3008000 r-xp /usr/lib/libSM.so.6.0.1
b3010000 b3011000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3019000 b301b000 r-xp /usr/lib/libledplayer.so.0.1
b3023000 b3029000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3031000 b3032000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b303b000 b3042000 r-xp /usr/lib/libGLESv2.so.2.0
b304a000 b3091000 r-xp /usr/lib/libtiff.so.5.1.0
b309c000 b30c5000 r-xp /usr/lib/libturbojpeg.so
b30de000 b30e2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30eb000 b30f1000 r-xp /usr/lib/libgif.so.4.1.6
b30f9000 b311b000 r-xp /usr/lib/libavutil.so.51.73.101
b312a000 b3158000 r-xp /usr/lib/libswscale.so.2.1.101
b3161000 b3458000 r-xp /usr/lib/libavcodec.so.54.59.100
b377f000 b3798000 r-xp /usr/lib/libpng12.so.0.50.0
b37a1000 b37a8000 r-xp /usr/lib/libfeedback.so.0.1.4
b37b1000 b37c4000 r-xp /usr/lib/libtts.so
b37cd000 b37cf000 r-xp /usr/lib/libEGL.so.1.4
b37d7000 b388e000 r-xp /usr/lib/libcairo.so.2.11200.12
b3898000 b38b1000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b38bb000 b38c0000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b38c8000 b38ca000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b38d2000 b417e000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41ef000 b41f8000 r-xp /usr/lib/libslp_devman_plugin.so
b4201000 b4203000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b420b000 b420e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4216000 b4219000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4221000 b422e000 r-xp /usr/lib/libmodem.so.0.0.0
b4236000 b4239000 r-xp /usr/lib/libdevice-node.so.0.1
b4241000 b4251000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4259000 b425c000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4264000 b426a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4272000 b4277000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b427f000 b4280000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4289000 b428c000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4294000 b4299000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b42a1000 b42a4000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b42ac000 b42ad000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b42b5000 b42c3000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b42cc000 b42d2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42da000 b42ff000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b4307000 b430a000 r-xp /usr/lib/libuuid.so.1.3.0
b4313000 b4327000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b432f000 b4337000 r-xp /usr/lib/libminizip.so.1.0.0
b433f000 b434b000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b4354000 b4372000 r-xp /usr/lib/libpcre.so.0.0.1
b437a000 b437e000 r-xp /usr/lib/libheynoti.so.0.0.2
b4386000 b4394000 r-xp /usr/lib/libdeviced.so.0.1.0
b439d000 b43a8000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b43b5000 b43be000 r-xp /usr/lib/libdevman.so.0.1
b43c6000 b43ca000 r-xp /usr/lib/libchromium.so.1.0
b43d2000 b43e3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b43ec000 b46f8000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b4720000 b472a000 r-xp /lib/libnss_files-2.13.so
b4733000 b4734000 r-xp /usr/lib/libpmapi.so.1.2
b473c000 b4743000 r-xp /usr/lib/libalarm.so.0.0.0
b474b000 b475e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4767000 b4783000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b478c000 b478f000 r-xp /usr/lib/libiniparser.so.0
b4798000 b47e8000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47f2000 b4803000 r-xp /usr/lib/libcom-core.so.0.0.1
b480b000 b4811000 r-xp /usr/lib/libappsvc.so.0.1.0
b4819000 b481b000 r-xp /usr/lib/libdri2.so.0.0.0
b4823000 b482b000 r-xp /usr/lib/libdrm.so.2.4.0
b4833000 b4837000 r-xp /usr/lib/libtbm.so.1.0.0
b483f000 b4842000 r-xp /usr/lib/libXv.so.1.0.0
b484a000 b4854000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b485d000 b4929000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b493f000 b494e000 r-xp /usr/lib/libnotification.so.0.1.0
b4956000 b497a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4983000 b4993000 r-xp /lib/libresolv-2.13.so
b4997000 b4999000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49a1000 b4a79000 r-xp /usr/lib/libxml2.so.2.7.8
b4a86000 b4b63000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b6e000 b4b73000 r-xp /usr/lib/libcheck.so.0.0.0
b4b7b000 b4b85000 r-xp /usr/lib/libspdy.so.0.0.0
b4b8e000 b4ce1000 r-xp /usr/lib/libcrypto.so.1.0.0
b4cff000 b4d4b000 r-xp /usr/lib/libssl.so.1.0.0
b4d57000 b4d85000 r-xp /usr/lib/libidn.so.11.5.44
b4d8e000 b4d98000 r-xp /usr/lib/libcares.so.2.1.0
b4da0000 b4db7000 r-xp /lib/libexpat.so.1.5.2
b4dc1000 b4de5000 r-xp /usr/lib/libicule.so.48.1
b4dee000 b4dfc000 r-xp /usr/lib/libsf_common.so
b4e05000 b4ea0000 r-xp /usr/lib/libstdc++.so.6.0.14
b4eb3000 b4ecb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4ecc000 b4ecf000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ed7000 b4edb000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ee4000 b4ee9000 r-xp /usr/lib/libffi.so.5.0.10
b4ef1000 b4ef2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4efa000 b4f04000 r-xp /usr/lib/libXext.so.6.4.0
b4f0d000 b4f10000 r-xp /usr/lib/libXtst.so.6.1.0
b4f18000 b4f1e000 r-xp /usr/lib/libXrender.so.1.3.0
b4f26000 b4f2c000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f34000 b4f35000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f3e000 b4f47000 r-xp /usr/lib/libXi.so.6.1.0
b4f4f000 b4f52000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f5a000 b4f5c000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f64000 b4f65000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f6e000 b4f75000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f7d000 b4fa0000 r-xp /usr/lib/libexif.so.12.3.3
b4fb4000 b4fbe000 r-xp /usr/lib/libethumb.so.1.7.99
b4fc6000 b500a000 r-xp /usr/lib/libsndfile.so.1.0.25
b5018000 b501a000 r-xp /usr/lib/libctxdata.so.0.0.0
b5022000 b5030000 r-xp /usr/lib/libremix.so.0.0.0
b5038000 b5039000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5041000 b505a000 r-xp /usr/lib/liblua-5.1.so
b5063000 b506a000 r-xp /usr/lib/libembryo.so.1.7.99
b5073000 b50b3000 r-xp /usr/lib/libcurl.so.4.3.0
b50bc000 b5126000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5133000 b5157000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5160000 b51bc000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b51ce000 b51e2000 r-xp /usr/lib/libfribidi.so.0.3.1
b51ea000 b5242000 r-xp /usr/lib/libfreetype.so.6.8.1
b524d000 b5271000 r-xp /usr/lib/libjpeg.so.8.0.2
b5289000 b52a0000 r-xp /lib/libz.so.1.2.5
b52a8000 b52b0000 r-xp /usr/lib/libemotion.so.1.7.99
b52b8000 b52bd000 r-xp /usr/lib/libecore_fb.so.1.7.99
b52c6000 b52d4000 r-xp /usr/lib/libsensor.so.1.1.0
b52e0000 b52e6000 r-xp /usr/lib/libappcore-common.so.1.1
b52ee000 b52f0000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.79
b52f8000 b5303000 r-xp /usr/lib/libresourced.so.0.2.79
b530b000 b530e000 r-xp /usr/lib/libproc-stat.so.0.2.79
b630b000 b63f3000 r-xp /usr/lib/libicuuc.so.48.1
b6400000 b6520000 r-xp /usr/lib/libicui18n.so.48.1
b652e000 b6531000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6539000 b6541000 r-xp /usr/lib/libvconf.so.0.2.45
b6549000 b654f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6557000 b6563000 r-xp /usr/lib/libail.so.0.1.0
b656b000 b6576000 r-xp /usr/lib/libaul.so.0.1.0
b657f000 b6596000 r-xp /usr/lib/libecore_input.so.1.7.99
b65b1000 b65ce000 r-xp /usr/lib/libecore_evas.so.1.7.99
b65d7000 b65d9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b65e1000 b6615000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b661e000 b664d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6657000 b6696000 r-xp /usr/lib/libeina.so.1.7.99
b669f000 b66b4000 r-xp /usr/lib/libecore.so.1.7.99
b66cb000 b66e6000 r-xp /usr/lib/libecore_con.so.1.7.99
b66ef000 b66f4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66fc000 b6704000 r-xp /usr/lib/libethumb_client.so.1.7.99
b670c000 b6715000 r-xp /usr/lib/libedbus.so.1.7.99
b671d000 b671f000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6727000 b672b000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6734000 b674a000 r-xp /usr/lib/libefreet.so.1.7.99
b6754000 b67b0000 r-xp /usr/lib/libedje.so.1.7.99
b67ba000 b686a000 r-xp /usr/lib/libevas.so.1.7.99
b688c000 b689f000 r-xp /usr/lib/libeet.so.1.7.99
b68a8000 b6912000 r-xp /lib/libm-2.13.so
b691b000 b6923000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b6924000 b692b000 r-xp /usr/lib/libutilX.so.1.1.0
b6933000 b6a55000 r-xp /usr/lib/libelementary.so.1.7.99
b6a6a000 b6a6d000 r-xp /lib/libattr.so.1.1.0
b6a75000 b6a77000 r-xp /usr/lib/libXau.so.6.0.0
b6a7f000 b6a85000 r-xp /lib/librt-2.13.so
b6a8e000 b6a96000 r-xp /lib/libcrypt-2.13.so
b6ac6000 b6ac9000 r-xp /lib/libcap.so.2.21
b6ad1000 b6ad3000 r-xp /usr/lib/libiri.so
b6adb000 b6af0000 r-xp /usr/lib/libxcb.so.1.1.0
b6af8000 b6b03000 r-xp /lib/libunwind.so.8.0.1
b6b31000 b6c4e000 r-xp /lib/libc-2.13.so
b6c5c000 b6c65000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c6d000 b6c99000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6ca2000 b6ca5000 r-xp /usr/lib/libbundle.so.0.1.22
b6cad000 b6caf000 r-xp /lib/libdl-2.13.so
b6cb8000 b6cbb000 r-xp /usr/lib/libsmack.so.1.0.0
b6cc3000 b6d9d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6da6000 b6dba000 r-xp /lib/libpthread-2.13.so
b6dc6000 b6dcb000 r-xp /usr/lib/libecore_file.so.1.7.99
b6dd3000 b6ddb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ddd000 b6dde000 r-xp /usr/lib/libdlog.so.0.0.0
b6de7000 b6e54000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e5e000 b6e67000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6f000 b6f55000 r-xp /usr/lib/libX11.so.6.3.0
b6f60000 b6f61000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f69000 b6f6d000 r-xp /usr/lib/libsys-assert.so
b6f75000 b6f92000 r-xp /lib/ld-2.13.so
befd7000 beff8000 rwxp [stack]
b6f75000 b6f92000 r-xp /lib/ld-2.13.so
befd7000 beff8000 rwxp [stack]
End of Maps Information

Callstack Information (PID:17094)
Call Stack Count: 48
 0: (0xb3d2d6d4) [/usr/lib/osp/libosp-uifw.so] + 0x45b6d4
 1: Tizen::Ui::Controls::ContextMenu::SetColor(Tizen::Graphics::Color const&) + 0xa (0xb3c1272b) [/usr/lib/osp/libosp-uifw.so] + 0x34072b
 2: MyHondanaDetailForm::OptionMenu() + 0x8a0 (0xb2ebe124) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x18124
 3: MyHondanaDetailForm::OnInitializing() + 0xbc (0xb2ebca0c) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x16a0c
 4: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b7dfb7) [/usr/lib/osp/libosp-uifw.so] + 0x2abfb7
 5: Tizen::Ui::Controls::_FormImpl::OnAttachedToMainTree() + 0x28 (0xb3d399ed) [/usr/lib/osp/libosp-uifw.so] + 0x4679ed
 6: Tizen::Ui::_Control::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0xb2 (0xb3b66793) [/usr/lib/osp/libosp-uifw.so] + 0x294793
 7: Tizen::Ui::_Control::EndAttaching(Tizen::Ui::_Control&) + 0xec (0xb3b6990d) [/usr/lib/osp/libosp-uifw.so] + 0x29790d
 8: Tizen::Ui::_Control::AttachChild(Tizen::Ui::_Control&) + 0x5a (0xb3b6c2ff) [/usr/lib/osp/libosp-uifw.so] + 0x29a2ff
 9: Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool) + 0xa4 (0xb3b894c1) [/usr/lib/osp/libosp-uifw.so] + 0x2b74c1
10: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x26 (0xb3b60b4f) [/usr/lib/osp/libosp-uifw.so] + 0x28eb4f
11: Tizen::Ui::Container::AddControl(Tizen::Ui::Control const&) + 0x6 (0xb3b60bdb) [/usr/lib/osp/libosp-uifw.so] + 0x28ebdb
12: (0xb3e02cc7) [/usr/lib/osp/libosp-uifw.so] + 0x530cc7
13: (0xb3e0360f) [/usr/lib/osp/libosp-uifw.so] + 0x53160f
14: (0xb3e0618d) [/usr/lib/osp/libosp-uifw.so] + 0x53418d
15: Tizen::Ui::Scenes::SceneManager::GoForward(Tizen::Ui::Scenes::ForwardSceneTransition const&, Tizen::Base::Collection::IList const*) + 0x18 (0xb3dfac95) [/usr/lib/osp/libosp-uifw.so] + 0x528c95
16: MyHondanaMainForm::OnIconListViewItemStateChanged(Tizen::Ui::Controls::IconListView&, int, Tizen::Ui::Controls::IconListViewItemStatus) + 0x2ac (0xb2ed05d0) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x2a5d0
17: non-virtual thunk to MyHondanaMainForm::OnIconListViewItemStateChanged(Tizen::Ui::Controls::IconListView&, int, Tizen::Ui::Controls::IconListViewItemStatus) + 0x4c (0xb2ed0764) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x2a764
18: (0xb3c21f49) [/usr/lib/osp/libosp-uifw.so] + 0x34ff49
19: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb453dec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
20: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb453e0fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
21: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb453e1ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
22: (0xb3d43e55) [/usr/lib/osp/libosp-uifw.so] + 0x471e55
23: (0xb3d28ab3) [/usr/lib/osp/libosp-uifw.so] + 0x456ab3
24: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb453dec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
25: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb453e0fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
26: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb453e1ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
27: (0xb3caf491) [/usr/lib/osp/libosp-uifw.so] + 0x3dd491
28: (0xb3cb1a1d) [/usr/lib/osp/libosp-uifw.so] + 0x3dfa1d
29: (0xb3cb6129) [/usr/lib/osp/libosp-uifw.so] + 0x3e4129
30: Tizen::Ui::Controls::_IconListView::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0xe (0xb3cb6aff) [/usr/lib/osp/libosp-uifw.so] + 0x3e4aff
31: Tizen::Ui::_ControlImpl::CallOnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x21a (0xb3b7fa63) [/usr/lib/osp/libosp-uifw.so] + 0x2ada63
32: Tizen::Ui::_ControlImpl::_PropagatedTouchEventListener::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x20c (0xb3b8789d) [/usr/lib/osp/libosp-uifw.so] + 0x2b589d
33: Tizen::Ui::_UiTouchEvent::FireListener(Tizen::Ui::_ITouchEventListener const*, Tizen::Ui::_Control const*, bool, bool&) + 0x1aa (0xb3bdf403) [/usr/lib/osp/libosp-uifw.so] + 0x30d403
34: Tizen::Ui::_UiTouchEvent::OnEventProcessing(Tizen::Ui::_Control const&, bool&) + 0x62 (0xb3bdf80f) [/usr/lib/osp/libosp-uifw.so] + 0x30d80f
35: Tizen::Ui::_UiEvent::ProcessEvent(Tizen::Ui::_Control const&, bool&) + 0x32 (0xb3bd3ee3) [/usr/lib/osp/libosp-uifw.so] + 0x301ee3
36: Tizen::Ui::_UiEventManager::ProcessBubblingEvent(Tizen::Base::Collection::LinkedListT<Tizen::Base::_HandleT<Tizen::Ui::_Control> > const&, Tizen::Ui::_UiEvent const&, bool&) + 0x6c (0xb3bd47b1) [/usr/lib/osp/libosp-uifw.so] + 0x3027b1
37: Tizen::Ui::_UiEventManager::ProcessEvent(Tizen::Ui::_UiEvent const&, bool&) + 0x1ec (0xb3bd4a09) [/usr/lib/osp/libosp-uifw.so] + 0x302a09
38: Tizen::Ui::_UiEventManager::Fire(Tizen::Ui::_UiEvent const&) + 0x8a (0xb3bd4aeb) [/usr/lib/osp/libosp-uifw.so] + 0x302aeb
39: Tizen::Ui::_UiEventManager::SendEvent(Tizen::Ui::_UiEvent const&) + 0x6 (0xb3bd4b7b) [/usr/lib/osp/libosp-uifw.so] + 0x302b7b
40: (0xb3bc4c7f) [/usr/lib/osp/libosp-uifw.so] + 0x2f2c7f
41: (0xb3bc830f) [/usr/lib/osp/libosp-uifw.so] + 0x2f630f
42: (0xb66a6aad) [/usr/lib/libecore.so.1] + 0x7aad
43: (0xb66aa153) [/usr/lib/libecore.so.1] + 0xb153
44: ecore_main_loop_begin + 0x30 (0xb66aa575) [/usr/lib/libecore.so.1] + 0xb575
45: elm_run + 0x6 (0xb69dcc73) [/usr/lib/libelementary.so.1] + 0xa9c73
46: appcore_efl_main + 0x114 (0xb6dd9268) [/usr/lib/libappcore-efl.so.1] + 0x6268
47: app_efl_main + 0xc6 (0xb42beed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
End of Call Stack

Package Information
Package Name: docomo6003.MyHondana
Package ID : docomo6003
Version: 1.0.0
Package Type: tpk
App Name: d book MyShelf
App ID: docomo6003.MyHondana
Type: Application
Categories: (NULL)
