S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMF4
Build-Date: 2013.06.25 21:23:12

Crash Information
Process Name: MyHondana
PID: 22696
Date: 2013-06-27 20:08:36(GMT+0900)
Executable File Path: /opt/apps/vMEuS5j7iC/bin/MyHondana
This process is multi-thread process
pid=22696 tid=22696
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 22696, uid 5000)
      TIMER: -2

Register Information
r0   = 0x00214f68, r1   = 0x00000000
r2   = 0x00000006, r3   = 0x00007069
r4   = 0x00000000, r5   = 0x001f34a0
r6   = 0x00000000, r7   = 0xb419fdd0
r8   = 0xb414d514, r9   = 0x00000002
r10  = 0xb414c9ac, fp   = 0xbecff67c
ip   = 0x00000010, sp   = 0xbecff598
lr   = 0xb3b2a347, pc   = 0xb4e48b34
cpsr = 0x080f0030

Memory Information
MemTotal:  2063912 KB
MemFree:    998224 KB
Buffers:     48620 KB
Cached:     656752 KB
VmPeak:     151352 KB
VmSize:     128864 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       45092 KB
VmRSS:       41040 KB
VmData:      27548 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       65972 KB
VmPTE:         122 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00071000 rw-p [heap]
00071000 00ca6000 rw-p [heap]
ae635000 ae638000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b05c3000 b05c7000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05d0000 b0dcf000 rwxp [stack:22700]
b0dcf000 b0f1d000 r-xp /usr/lib/r3p2/libMali.so
b0f29000 b0f51000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f55000 b0f73000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f7c000 b0f7d000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b0f85000 b0f8b000 r-xp /usr/lib/libUMP.so
b12cc000 b1318000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b1321000 b1326000 r-xp /usr/lib/libjson.so.0.0.1
b132e000 b1332000 r-xp /usr/lib/liblocation-pos-log.so
b133a000 b1345000 r-xp /usr/lib/libmdm-common.so.1.0.37
b134d000 b135f000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1367000 b1369000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b1371000 b1376000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b137e000 b1389000 r-xp /usr/lib/libdrm-trusted.so.0.0.51
b1391000 b1393000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b139b000 b13a8000 r-xp /usr/lib/libdrm-client.so.0.0.90
b13b1000 b13b9000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13db000 b1412000 r-xp /usr/lib/libpulse.so.0.16.2
b141a000 b147e000 r-xp /usr/lib/libasound.so.2.0.0
b1488000 b148b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1494000 b1498000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b14a1000 b14be000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b14c6000 b14ca000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14d2000 b14ff000 r-xp /usr/lib/libSLP-location.so.0.0.0
b1508000 b1545000 r-xp /usr/lib/libmdm.so.1.0.63
b154d000 b1551000 r-xp /usr/lib/libss-client.so.1.0.0
b155a000 b1563000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b156b000 b156f000 r-xp /usr/lib/libmmffile.so.0.0.0
b1577000 b157e000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1586000 b15a0000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b15a8000 b15c3000 r-xp /usr/lib/libmedia-service.so.1.0.0
b15cb000 b15e0000 r-xp /usr/lib/libnetwork.so.0.0.0
b15e8000 b15f6000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.6
b15ff000 b1606000 r-xp /usr/lib/libenchant.so.1.6.1
b160e000 b1611000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b161a000 b1623000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b162c000 b1630000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1639000 b1647000 r-xp /usr/lib/libmmfsound.so.0.1.0
b164f000 b1654000 r-xp /usr/lib/libmemenv.so.1.1.0
b165c000 b169a000 r-xp /usr/lib/libleveldb.so.1.1.0
b16a3000 b16cd000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b16d6000 b16d8000 r-xp /usr/lib/libsecfw.so
b16e0000 b16e9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b16f4000 b1703000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b170b000 b1723000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1725000 b1732000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b173b000 b1744000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b174c000 b178e000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1797000 b1833000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b183f000 b1864000 r-xp /usr/lib/libxslt.so.1.1.16
b186d000 b186f000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b1877000 b187f000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1887000 b1892000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b189a000 b18b5000 r-xp /usr/lib/libwifi-direct.so.0.0
b18bd000 b18c5000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.6
b18cd000 b18d6000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b18de000 b18e1000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b18e9000 b1910000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1918000 b192e000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1937000 b1941000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b1949000 b1952000 r-xp /usr/lib/libcapi-web-favorites.so
b195a000 b2baa000 r-xp /usr/lib/libewebkit2.so.0.10.141.3
b2c9c000 b2d51000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2d5e000 b2d7c000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2d85000 b2d9f000 r-xp /usr/lib/osp/libosp-json.so.1.2.1.0
b2da8000 b2dfb000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2e04000 b2e68000 r-xp /usr/lib/osp/libosp-web.so.1.2.1.0
b2e7b000 b2e85000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2e8d000 b2ea2000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana.exe
b2eac000 b2ef4000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2efc000 b2f8c000 r-xp /usr/lib/libCOREGL.so.3.0
b2f96000 b2f99000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fa1000 b2fa8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fb1000 b2fc0000 r-xp /usr/lib/libICE.so.6.3.0
b2fca000 b2fcf000 r-xp /usr/lib/libSM.so.6.0.1
b2fd7000 b2fd8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fe0000 b2fe2000 r-xp /usr/lib/libledplayer.so.0.1
b2fea000 b2ff0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2ff8000 b2ff9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3002000 b3009000 r-xp /usr/lib/libGLESv2.so.2.0
b3011000 b3058000 r-xp /usr/lib/libtiff.so.5.1.0
b3063000 b308c000 r-xp /usr/lib/libturbojpeg.so
b30a5000 b30a9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30b2000 b30b8000 r-xp /usr/lib/libgif.so.4.1.6
b30c0000 b30e2000 r-xp /usr/lib/libavutil.so.51.73.101
b30f1000 b311f000 r-xp /usr/lib/libswscale.so.2.1.101
b3128000 b341f000 r-xp /usr/lib/libavcodec.so.54.59.100
b3746000 b375f000 r-xp /usr/lib/libpng12.so.0.50.0
b3768000 b376f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3778000 b378b000 r-xp /usr/lib/libtts.so
b3793000 b3795000 r-xp /usr/lib/libEGL.so.1.4
b379d000 b3854000 r-xp /usr/lib/libcairo.so.2.11200.12
b385e000 b3877000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3881000 b3886000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b388e000 b3890000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana
b3898000 b413a000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41aa000 b41b3000 r-xp /usr/lib/libslp_devman_plugin.so
b41bc000 b41be000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41c6000 b41c9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41d1000 b41d4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41dc000 b41e9000 r-xp /usr/lib/libmodem.so.0.0.0
b41f1000 b41f4000 r-xp /usr/lib/libdevice-node.so.0.1
b41fc000 b420c000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4214000 b4217000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b421f000 b422a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4232000 b4239000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4242000 b4247000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b424f000 b4250000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4259000 b425c000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4264000 b4269000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4271000 b4274000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b427c000 b427d000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b4285000 b4293000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b429c000 b42a2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42aa000 b42cf000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42d7000 b42da000 r-xp /usr/lib/libuuid.so.1.3.0
b42e3000 b42f7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b42ff000 b4300000 r-xp /usr/lib/libpmapi.so.1.2
b4308000 b4310000 r-xp /usr/lib/libminizip.so.1.0.0
b4318000 b4324000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b432d000 b434b000 r-xp /usr/lib/libpcre.so.0.0.1
b4353000 b4357000 r-xp /usr/lib/libheynoti.so.0.0.2
b435f000 b436d000 r-xp /usr/lib/libdeviced.so.0.1.0
b4376000 b4381000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b438e000 b4397000 r-xp /usr/lib/libdevman.so.0.1
b439f000 b43a3000 r-xp /usr/lib/libchromium.so.1.0
b43ab000 b43b2000 r-xp /usr/lib/libalarm.so.0.0.0
b43ba000 b46c7000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b46ef000 b46f9000 r-xp /lib/libnss_files-2.13.so
b4709000 b4719000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.3
b471a000 b472d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4735000 b4752000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b475a000 b475d000 r-xp /usr/lib/libiniparser.so.0
b4766000 b47b6000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47c0000 b47d4000 r-xp /usr/lib/libcom-core.so.0.0.1
b47dc000 b47e2000 r-xp /usr/lib/libappsvc.so.0.1.0
b47ea000 b47ec000 r-xp /usr/lib/libdri2.so.0.0.0
b47f4000 b47fc000 r-xp /usr/lib/libdrm.so.2.4.0
b4804000 b4808000 r-xp /usr/lib/libtbm.so.1.0.0
b4810000 b4813000 r-xp /usr/lib/libXv.so.1.0.0
b481b000 b48e7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48fd000 b490c000 r-xp /usr/lib/libnotification.so.0.1.0
b4914000 b4938000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4941000 b4951000 r-xp /lib/libresolv-2.13.so
b4955000 b4957000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b495f000 b4a37000 r-xp /usr/lib/libxml2.so.2.7.8
b4a44000 b4b21000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b2c000 b4b31000 r-xp /usr/lib/libcheck.so.0.0.0
b4b39000 b4b43000 r-xp /usr/lib/libspdy.so.0.0.0
b4b4c000 b4c9f000 r-xp /usr/lib/libcrypto.so.1.0.0
b4cbd000 b4d09000 r-xp /usr/lib/libssl.so.1.0.0
b4d15000 b4d43000 r-xp /usr/lib/libidn.so.11.5.44
b4d4c000 b4d56000 r-xp /usr/lib/libcares.so.2.1.0
b4d5e000 b4d75000 r-xp /lib/libexpat.so.1.5.2
b4d7f000 b4da3000 r-xp /usr/lib/libicule.so.48.1
b4dac000 b4dba000 r-xp /usr/lib/libsf_common.so
b4dc3000 b4e5e000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e71000 b4e89000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4e8a000 b4e8d000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e95000 b4e99000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ea2000 b4ea7000 r-xp /usr/lib/libffi.so.5.0.10
b4eaf000 b4eb0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4eb8000 b4ec2000 r-xp /usr/lib/libXext.so.6.4.0
b4ecb000 b4ece000 r-xp /usr/lib/libXtst.so.6.1.0
b4ed6000 b4edc000 r-xp /usr/lib/libXrender.so.1.3.0
b4ee4000 b4eea000 r-xp /usr/lib/libXrandr.so.2.2.0
b4ef2000 b4ef3000 r-xp /usr/lib/libXinerama.so.1.0.0
b4efc000 b4f05000 r-xp /usr/lib/libXi.so.6.1.0
b4f0d000 b4f10000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f18000 b4f1a000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f22000 b4f23000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f2c000 b4f33000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f3b000 b4f5e000 r-xp /usr/lib/libexif.so.12.3.3
b4f72000 b4f7c000 r-xp /usr/lib/libethumb.so.1.7.99
b4f84000 b4fc8000 r-xp /usr/lib/libsndfile.so.1.0.25
b4fd6000 b4fd8000 r-xp /usr/lib/libctxdata.so.0.0.0
b4fe0000 b4fee000 r-xp /usr/lib/libremix.so.0.0.0
b4ff6000 b4ff7000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4fff000 b5018000 r-xp /usr/lib/liblua-5.1.so
b5021000 b5028000 r-xp /usr/lib/libembryo.so.1.7.99
b5031000 b5071000 r-xp /usr/lib/libcurl.so.4.3.0
b507a000 b50e4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b50f1000 b5115000 r-xp /usr/lib/libfontconfig.so.1.5.0
b511e000 b517a000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b518c000 b51a0000 r-xp /usr/lib/libfribidi.so.0.3.1
b51a8000 b5200000 r-xp /usr/lib/libfreetype.so.6.8.1
b520b000 b522f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5247000 b525e000 r-xp /lib/libz.so.1.2.5
b5266000 b526e000 r-xp /usr/lib/libemotion.so.1.7.99
b5276000 b527b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5284000 b5292000 r-xp /usr/lib/libsensor.so.1.1.0
b529e000 b52a4000 r-xp /usr/lib/libappcore-common.so.1.1
b52ac000 b52ae000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.78
b52b6000 b52bf000 r-xp /usr/lib/libresourced.so.0.2.78
b52c8000 b52cb000 r-xp /usr/lib/libproc-stat.so.0.2.78
b62c8000 b63b0000 r-xp /usr/lib/libicuuc.so.48.1
b63bd000 b64dd000 r-xp /usr/lib/libicui18n.so.48.1
b64eb000 b64ee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64f6000 b64ff000 r-xp /usr/lib/libvconf.so.0.2.45
b6507000 b650d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6515000 b6521000 r-xp /usr/lib/libail.so.0.1.0
b6529000 b6534000 r-xp /usr/lib/libaul.so.0.1.0
b653c000 b6553000 r-xp /usr/lib/libecore_input.so.1.7.99
b656e000 b658b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6594000 b6596000 r-xp /usr/lib/libXcomposite.so.1.0.0
b659e000 b65d2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b65db000 b660a000 r-xp /usr/lib/libecore_x.so.1.7.99
b6614000 b6653000 r-xp /usr/lib/libeina.so.1.7.99
b665c000 b6671000 r-xp /usr/lib/libecore.so.1.7.99
b6688000 b66a3000 r-xp /usr/lib/libecore_con.so.1.7.99
b66ac000 b66b1000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66b9000 b66c1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66c9000 b66d2000 r-xp /usr/lib/libedbus.so.1.7.99
b66da000 b66dc000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b66e4000 b66e8000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b66f1000 b6707000 r-xp /usr/lib/libefreet.so.1.7.99
b6711000 b676d000 r-xp /usr/lib/libedje.so.1.7.99
b6777000 b6827000 r-xp /usr/lib/libevas.so.1.7.99
b6849000 b685c000 r-xp /usr/lib/libeet.so.1.7.99
b6865000 b68cf000 r-xp /lib/libm-2.13.so
b68d8000 b68e0000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b68e1000 b68e8000 r-xp /usr/lib/libutilX.so.1.1.0
b68f0000 b6a12000 r-xp /usr/lib/libelementary.so.1.7.99
b6a27000 b6a2a000 r-xp /lib/libattr.so.1.1.0
b6a32000 b6a34000 r-xp /usr/lib/libXau.so.6.0.0
b6a3c000 b6a42000 r-xp /lib/librt-2.13.so
b6a4b000 b6a53000 r-xp /lib/libcrypt-2.13.so
b6a83000 b6a86000 r-xp /lib/libcap.so.2.21
b6a8e000 b6a90000 r-xp /usr/lib/libiri.so
b6a98000 b6aad000 r-xp /usr/lib/libxcb.so.1.1.0
b6ab5000 b6ac0000 r-xp /lib/libunwind.so.8.0.1
b6aee000 b6c0b000 r-xp /lib/libc-2.13.so
b6c19000 b6c22000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c2a000 b6c56000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c5f000 b6c62000 r-xp /usr/lib/libbundle.so.0.1.22
b6c6a000 b6c6c000 r-xp /lib/libdl-2.13.so
b6c75000 b6c78000 r-xp /usr/lib/libsmack.so.1.0.0
b6c80000 b6d5a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d63000 b6d77000 r-xp /lib/libpthread-2.13.so
b6d83000 b6d88000 r-xp /usr/lib/libecore_file.so.1.7.99
b6d90000 b6d98000 r-xp /usr/lib/libappcore-efl.so.1.1
b6d9a000 b6d9b000 r-xp /usr/lib/libdlog.so.0.0.0
b6da4000 b6e11000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e1b000 b6e24000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2c000 b6f12000 r-xp /usr/lib/libX11.so.6.3.0
b6f1d000 b6f1e000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f26000 b6f2a000 r-xp /usr/lib/libsys-assert.so
b6f32000 b6f4f000 r-xp /lib/ld-2.13.so
bece1000 bed02000 rwxp [stack]
End of Maps Information

Callstack Information (PID:22696)
Call Stack Count: 19
 0: __dynamic_cast + 0x33 (0xb4e48b34) [/usr/lib/libstdc++.so.6] + 0x85b34
 1: (0xb3b2a347) [/usr/lib/osp/libosp-uifw.so] + 0x292347
 2: Tizen::Ui::_Control::Accept(Tizen::Ui::_Control::Visitor&) + 0x14 (0xb3b2b0cd) [/usr/lib/osp/libosp-uifw.so] + 0x2930cd
 3: Tizen::Ui::_Control::Accept(Tizen::Ui::_Control::Visitor&) const + 0x6 (0xb3b2b25f) [/usr/lib/osp/libosp-uifw.so] + 0x29325f
 4: Tizen::Ui::_Control::GetRootWindow() const + 0x22 (0xb3b2b2ef) [/usr/lib/osp/libosp-uifw.so] + 0x2932ef
 5: Tizen::Ui::_Control::CallOnDetachingFromMainTree(Tizen::Ui::_Control&) + 0x20 (0xb3b2b355) [/usr/lib/osp/libosp-uifw.so] + 0x293355
 6: Tizen::Ui::_Control::CallOnDetachingFromMainTree(Tizen::Ui::_Control&) + 0xc8 (0xb3b2b3fd) [/usr/lib/osp/libosp-uifw.so] + 0x2933fd
 7: Tizen::Ui::_Control::DetachChild(Tizen::Ui::_Control&) + 0xc2 (0xb3b2f6f7) [/usr/lib/osp/libosp-uifw.so] + 0x2976f7
 8: Tizen::Ui::_Control::DetachAllChildren(bool, bool) + 0xcc (0xb3b2f905) [/usr/lib/osp/libosp-uifw.so] + 0x297905
 9: Tizen::Ui::_ContainerImpl::RemoveAllChildren(bool, bool) + 0x1e (0xb3b4e4d3) [/usr/lib/osp/libosp-uifw.so] + 0x2b64d3
10: Tizen::Ui::_WindowImpl::Destroy() + 0x32 (0xb3b4fa53) [/usr/lib/osp/libosp-uifw.so] + 0x2b7a53
11: Tizen::App::_UiAppImpl::RemoveAllFrames() + 0x58 (0xb3ef83c1) [/usr/lib/osp/libosp-uifw.so] + 0x6603c1
12: Tizen::App::_UiAppImpl::OnUiAppImplTerminating() + 0x8 (0xb3ef87a5) [/usr/lib/osp/libosp-uifw.so] + 0x6607a5
13: Tizen::App::_UiAppImpl::OnTerminate() + 0x38 (0xb3ef8811) [/usr/lib/osp/libosp-uifw.so] + 0x660811
14: Tizen::App::_AppImpl::OnTerminate(void*) + 0x42 (0xb44a9f37) [/usr/lib/osp/libosp-appfw.so] + 0xeff37
15: (0xb428ec31) [/usr/lib/libcapi-appfw-application.so.0] + 0x9c31
16: (0xb6d94b0c) [/usr/lib/libappcore-efl.so.1] + 0x4b0c
17: appcore_efl_main + 0x1f0 (0xb6d96344) [/usr/lib/libappcore-efl.so.1] + 0x6344
18: app_efl_main + 0xc6 (0xb428eed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
End of Call Stack

Package Information
Package Name: vMEuS5j7iC.MyHondana
Package ID : vMEuS5j7iC
Version: 1.0.0
Package Type: tpk
App Name: MyHondana
App ID: vMEuS5j7iC.MyHondana
Type: Application
Categories: (NULL)
